    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;

namespace Shopping.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<BadamUser> _signInManager;
        private readonly UserManager<BadamUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;
        public RegisterModel(
            UserManager<BadamUser> userManager,
            SignInManager<BadamUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _configuration = configuration;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email boş buraxıla bilməz")]
            [EmailAddress(ErrorMessage = "E-poçt düzgün daxil edilməmişdir.")]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Ad boş buraxıla bilməz")]
            [Display(Name = "Fullname")]
            public string Fullname { get; set; }

            [Required(ErrorMessage = "Telefon boş buraxıla bilməz")]
            [Phone]
            [Display(Name = "Phone")]
            public string Phone { get; set; }
            [Required(ErrorMessage = "Şifrə boş buraxıla bilməz")]
            [StringLength(100, ErrorMessage = "Şifrə ən azı {2},maksimum {1} simvoldan ibarət olmalıdır.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }
            [Required(ErrorMessage = "Şifrə boş buraxıla bilməz")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "Şifrə və şifrə təkrarı eyni olmalidir.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new BadamUser { UserName = Input.Email, Email = Input.Email,PhoneNumber=Input.Phone,FullName=Input.Fullname };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);
                       
                    var email = _configuration["Gmail:Email"];
                        var password = _configuration["Gmail:Password"];
                        var host = _configuration["Gmail:Host"];
                        bool EnableSsl = Convert.ToBoolean(_configuration["Gmail:EnableSsl"]);
                        var Port = _configuration["Gmail:Port"];
                        var InputEmail = Input.Email;
                    using (MailMessage message = new(email, InputEmail))
                    {
                        message.Subject = "Subject";
                        message.IsBodyHtml = true;
                        message.Body = $"Confirm your email Place confirm your account by <a href=`{HtmlEncoder.Default.Encode(callbackUrl)}`>clicking here </a.>";

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

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
