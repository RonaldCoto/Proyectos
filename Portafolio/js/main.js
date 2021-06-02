/* accordion skills */ 
const skillsContent = document.getElementsByClassName('skills_content'),
      skillsHeader = document.querySelectorAll('.skills_header')  

function toggleskills(){
    let itemClass = this.parentNode.className

    for(i = 0; i < skillsContent.length; i++){
        skillsContent[i].className = 'skills_content skills_close'
    }

    if(itemClass === 'skills_content skills_close'){
        this.parentNode.className = 'skills_content skills_open'
    }
}

skillsHeader.forEach((el) =>{
    el.addEventListener('click', toggleskills)
})


/* show scroll-up */ 
function scrollUp(){
    const scrollup = document.getElementById('scroll-up');

    if(this.scrollY >=560)
        scrollup.classList.add('show-scroll');
    else
        scrollup.classList.remove('show-scroll')
}
window.addEventListener('scroll',scrollUp)