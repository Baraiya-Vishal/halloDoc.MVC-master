const fphoneInputField = document.querySelector("#f-phone");
const fphoneInput = window.intlTelInput(fphoneInputField, {
    utilsScript:"https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.8/js/utils.js"
});



const zphoneInputField = document.querySelector("#phone");
const zphoneInput = window.intlTelInput(zphoneInputField, {
    utilsScript:"https://cdnjs.cloudflare.com/ajax/libs/intl-tel-input/17.0.8/js/utils.js"
})

document.getElementById("formFile").onchange = function () {
    document.getElementById("filename").value = this.value;
};

var right=document.getElementById('email').style.height;
var left=document.getElementById('phone').style.height;
if(left>right)
{
    document.getElementById('email').style.height=left;
}
else
{
    document.getElementById('phone').style.height=right;
}