'use strict';

$('.cart-close').on("click", function () {
    $('.cart-sidebar').removeClass('active'),
        $('body').css('overflow-y', 'scroll'),
        $('.off_canvars_overlay').removeClass('active')

});



$(function () {
    let cookieVal = getCookie("myCart");
    let wishVal = getCookie("wishCart");

    if (typeof cookieVal !== "undefined" && cookieVal !== "" && cookieVal !== null) {
        cookieVal = [...cookieVal.split("-")]
        let uniqeQuantity = [...new Set(cookieVal)];
        $(".shop-quantity").text(uniqeQuantity.length);
        $(".cart-total-quantity").text(uniqeQuantity.length);
    }

    if (typeof wishVal !== "undefined" && wishVal !== "" && wishVal !== null) {
        wishVal = [...wishVal.split("-")]
        $(".shop-wishlist").text(wishVal.length);
    }



    $(".shop-icon").click(function () {
        $('.cart-sidebar').addClass('active'),
            $('body').css('overflow-y', 'hidden'),
            $('.off_canvars_overlay').addClass('active')
       
        $.ajax({
            url: "/Shared/GetCartProduct",
            type: "JSON",
            success: function (res) {
                console.log(res)
                $(".shopping-cart .myCart").html(res)
            }
        })
    })

    let productIds = cookieVal != "" ? cookieVal : [];
    let wishListIds = wishVal != "" ? wishVal : [];


    $(".add-to-cart").click(function () {
        debugger;
        const productId = $(this).attr("proId")
        var plusminusbox = Number($(".cart__item__quantity").val())
        console.log(plusminusbox)
        debugger;
        if (typeof plusminusbox != "number") {
            for (let i = 1; i < plusminusbox; i++) {
                productIds.push(productId);
            }
        } else {
            productIds.push(productId);
        }



        setCookie('myCart', productIds.join("-"), 7);
        let uniqeQuantity = [...new Set(productIds)];
        $(".shop-quantity").text(uniqeQuantity.length);
        $(".cart-total-quantity").text(uniqeQuantity.length);
 

        Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'Məhsul səbətə əlavə olundu',
            showConfirmButton: false,
            timer: 1500
        })
    })
    $(".wishlist").click(function () {
        const productId = $(this).attr("proId")
        wishListIds.push(productId);
        setCookie('wishCart', wishListIds.join("-"), 7);
        $(".shop-wishlist").text(wishListIds.length);

        Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'Bəyənilənlərə əlavə olundu',
            showConfirmButton: false,
            timer: 1500
        })
    })

   



    $(".table-scroll .trash").click(function () {
        const wishProductId = $(this).attr("cart-id")
        wishListIds = wishListIds.filter(x => x != wishProductId)
        setCookie('wishCart', wishListIds.join("-"), 7);
        $(this).parents(".wish-tr").remove()
        if (wishListIds.length <= 0) {
            $(".table-scroll .wish-table ").html(`<p class="alert alert-success">Bəyənilən məhsul yoxdur!</p>`)
        }

    })

    

    function setCookie(cname, cvalue, exdays) {
        const d = new Date();
        d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
        let expires = "expires=" + d.toUTCString();
        document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
    }

    function getCookie(cname) {
        let name = cname + "=";
        let ca = document.cookie.split(';');
        for (let i = 0; i < ca.length; i++) {
            let c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    }
})
function openCity(evt, cityName) {
    var i, tabcontent, tablinks;

    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}