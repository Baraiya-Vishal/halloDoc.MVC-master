
document.getElementById('btnSwitch').addEventListener('click',()=>{
    
    if (document.documentElement.getAttribute('data-bs-theme') == 'dark') {
   
    let btn_1=document.querySelectorAll(".btn-1"); 
    let btn_2=document.querySelectorAll(".btn-2");
    let btn_3=document.querySelectorAll(".btn-3");
    let btn_4=document.querySelectorAll(".btn-4");
    

    btn_1.forEach(box => {
        box.classList.add("d-btn-1")
      });

    btn_2.forEach(box => {
        box.classList.add("d-btn-2")
      });

      btn_3.forEach(box => {
        box.classList.add("d-btn-3")
      });

      btn_4.forEach(box => {
        box.classList.add("d-btn-4")
      });
  


}
else {
   
}

})