localStorage.setItem("mode", 0);


function showpass() {
    var x = document.getElementById("Password");
    var y = document.getElementById("eye");
    if (x.type == "password") {
      x.type = "text";
      y.src="/images/eye.svg";

    } else {
      x.type = "password";
      y.src="/images/eye-slash.svg";
    }
}

 function  dark() {

    // dark mode java script 
    document.getElementById('btnSwitch').addEventListener('click', () => {
        if (0 == localStorage.getItem("mode")) {


            // if (document.documentElement.getAttribute('data-bs-theme') == 'light') 
            document.documentElement.setAttribute('data-bs-theme', 'dark')


            let text_2 = document.querySelectorAll(".text-2");

            text_2.forEach(box => {
                box.classList.add("d-text-2")
            });

            let form_control = document.querySelectorAll(".form-control");

            form_control.forEach(box => {
                box.classList.add("d-form-control")
            });

            var bg_grey = document.querySelectorAll(".myheading");
            for (var i = 0; i < bg_grey.length; i++) {
                bg_grey[i].style.color = "white";
            }

            localStorage.setItem("mode", 1);

        }
        else {

            document.documentElement.setAttribute('data-bs-theme', 'light');
            let text_2 = document.querySelectorAll(".text-2");
            text_2.forEach(box => {
                box.classList.remove("d-text-2")
            });

            let form_control = document.querySelectorAll(".form-control");

            form_control.forEach(box => {
                box.classList.remove("d-form-control")
            });

            var bg_grey = document.querySelectorAll(".myheading");
            for (var i = 0; i < bg_grey.length; i++) {
                bg_grey[i].style.color = "black";
            }

            localStorage.setItem("mode", 0);
        }
    })


}






