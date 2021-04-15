const menu = document.querySelector('#mobile-menu');
const menuLinks = document.querySelector('.navbar__menu');
const navLogo = document.querySelector('#navbar__logo');

// Show active menu when scrolling
const highlightMenu = () => {
    const element = document.querySelector('.highlight');
    const homeMenu = document.querySelector('#home-page');
    const aboutMenu = document.querySelector('#about-page');
    const projectsMenu = document.querySelector('#projects-page');
    let scrollPosition = window.scrollY;
    // console.log(scrollPos);
  
    // adds 'highlight' class to my menu items
    if (window.innerWidth > 960 && scrollPosition < 600) {
      homeMenu.classList.add('highlight');
      aboutMenu.classList.remove('highlight');
      return;
    } 

    else if (window.innerWidth > 960 && scrollPosition < 1400) {
      aboutMenu.classList.add('highlight');
      homeMenu.classList.remove('highlight');
      projectsMenu.classList.remove('highlight');
      return;
    } 
    
    else if (window.innerWidth > 960 && scrollPosition < 2345) {
      projectsMenu.classList.add('highlight');
      aboutMenu.classList.remove('highlight');
      return;
    }
  
    if ((element && window.innerWIdth < 960 && scrollPosition < 600) || element) {
        element.classList.remove('highlight');
    }
  };

window.addEventListener('scroll', highlightMenu);
window.addEventListener('click', highlightMenu);