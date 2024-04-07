let menuIcon = document.querySelector('#menu-icon');
let navbar = document.querySelector('.mynavbar');

menuIcon.onclick =()=>{
    menuIcon.classList.toggle('bx-x',header.style.backgroundColor = '#1f242d');
    navbar.classList.toggle('active');
    
};


let sections = document.querySelectorAll('section');
let navlinks = document.querySelectorAll('header nav a');

window.onscroll =()=>{
    sections.forEach(sec =>{
        let top = window.scrollY;
        let ofset = sec.offsetTop - 150;
        let height = sec.offsetHeight;
        let id = sec.getAttribute('id');

        if(top>= ofset && top < ofset + height){
            navlinks.forEach(links =>{
                links.classList.remove('active');
                document.querySelector('header nav a[href*=' + id + ']').classList.add('active');
            });
        };
    });
    let header = document.querySelector('header');

    header.classList.toggle('sticky',window.scrollY > 100);

    menuIcon.classList.remove('bx-x');
    navbar.classList.remove('active');
};


document.addEventListener('scroll', () => {
	var scroll_position = window.scrollY;
	if (scroll_position > 0) {
		header.style.backgroundColor = '#1f242d';
	} else {
		header.style.backgroundColor = 'transparent';
	}
});
