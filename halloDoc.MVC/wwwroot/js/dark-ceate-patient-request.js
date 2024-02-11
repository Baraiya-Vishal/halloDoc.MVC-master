
document.getElementById('btnSwitch').addEventListener('click',()=>{
    
    if (document.documentElement.getAttribute('data-bs-theme') == 'light') {
   
    // var bg_grey = document.getElementsByClassName(".bg-grey");

      
    //   bg_grey.forEach(box => {
    //     box.style.backgroundColor("red");
    //   });

       


      var  bg_grey = document.querySelectorAll(".bg-grey");
    for (var i = 0; i < bg_grey.length; i++) {
        bg_grey[i].style.backgroundColor = "#f7f3f3";
    }
    
    var  bg_white = document.querySelectorAll(".bg-white");
    bg_white.forEach(box => {
      box.classList.remove("d-bg-white")
    });

    var  bg_grey = document.querySelectorAll(".myheading");
    for (var i = 0; i < bg_grey.length; i++) {
        bg_grey[i].style.color = "black";
    }

}
else {
  var  bg_grey = document.querySelectorAll(".bg-grey");
  for (var i = 0; i < bg_grey.length; i++) {
      bg_grey[i].style.backgroundColor = "#212529";
  }

  var  bg_white = document.querySelectorAll(".bg-white");
    bg_white.forEach(box => {
      box.classList.add("d-bg-white")
    });

    var  bg_grey = document.querySelectorAll(".myheading");
    for (var i = 0; i < bg_grey.length; i++) {
        bg_grey[i].style.color = "white";
    }
   
}

})