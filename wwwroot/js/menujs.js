
const Mobile= document.querySelector('.menu-toggle');
const MobileLink= document.querySelector('.mysidebar');

Mobile.addEventListener('click', function(){
    Mobile.classList.toggle('is-active');
    MobileLink.classList.toggle('active');
})



const menu=document.getElementById("menu");
const detail=document.getElementById("detail");
window.addEventListener("scroll",()=>{
    if(window.scrollY > 210){
        menu.classList.add("active");
        detail.classList.add("active");

    }else{
        menu.classList.remove("active");
        detail.classList.remove("active");
    }
})



let sections = document.querySelectorAll('.detail-card');
let navlinks = document.querySelectorAll('ul li a');
window.onscroll =()=>{
    sections.forEach(sec =>{
        let top = window.scrollY;
        let ofset = sec.offsetTop -20;
        let height = sec.offsetHeight;
        let id = sec.getAttribute('id');

        if(top>= ofset && top < ofset + height){
            navlinks.forEach(links =>{
                links.classList.remove('active');
                document.querySelector('ul li a[href*=' + id + ']').classList.add('active');
            });
        };
    });
}


MobileLink.addEventListener('click', function(){
    const menuBars = document.querySelector('.is-active');
    if(window.innerWidth<=855 && menuBars){
        Mobile.classList.toggle('is-active');
        MobileLink.classList.toggle('active');
    }
})




