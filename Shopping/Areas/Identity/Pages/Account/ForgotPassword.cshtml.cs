using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Entities;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;

namespace Shopping.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<BadamUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;

        public ForgotPasswordModel(UserManager<BadamUser> userManager, IEmailSender emailSender, IConfiguration configuration)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _configuration = configuration;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email boş buraxıla bilməz")]
            [EmailAddress(ErrorMessage = "E-poçt düzgün daxil edilməmişdir.")]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please 
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code },
                    protocol: Request.Scheme);

                var email = _configuration["Gmail:Email"];
                var password= _configuration["Gmail:Password"];
                var host= _configuration["Gmail:Host"];
                bool EnableSsl = Convert.ToBoolean(_configuration["Gmail:EnableSsl"]);
                var Port = _configuration["Gmail:Port"];
                var InputEmail = Input.Email;
                using (MailMessage message = new(email, InputEmail))
                {
                    message.Subject = "Subject";
                    message.IsBodyHtml = true;
                    message.Body = $"E-poçtunuzu təsdiq edin.Hesabınızı təsdiqləyin <a href=`{HtmlEncoder.Default.Encode(callbackUrl)}`>bura daxil olun. </a.>";

                    using SmtpClient smtp = new();
                    smtp.Host = host;
                    smtp.EnableSsl = EnableSsl;

                    NetworkCredential cred = new(email, password);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = cred;
                    smtp.Port = Convert.ToInt32(Port);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Send(message);

                }

                    await _emailSender.SendEmailAsync(
                        Input.Email,
                        "Reset Password",
                        $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                return RedirectToPage("./ForgotPasswordConfirmation");
            }

            return Page();
        }
    }
}
