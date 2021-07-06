function openNav(navId) {
    var slideBar = document.getElementById(navId);
    slideBar.style.zIndex = "1";
    slideBar.style.opacity = "1";
    slideBar.style.transform = "none";
    slideBar.style.transition = "transform 0.3s ease-in-out 0s";
    if(navId == "SlidingNav"){
        var shadow = document.getElementById("ShadowLayer");
        shadow.style.opacity = "1";
        shadow.style.pointerEvents = "auto";
    }

}
function closeNav(navId) {
    var slideBar = document.getElementById(navId);

    slideBar.style.zIndex = "0";
    slideBar.style.opacity = "0";
    slideBar.style.transform = "translate(100vw, 0px)";
    slideBar.style.transition = "opacity 0s linear 0.4s, transform 0.3s ease-in-out 0s";
    if (navId == "SlidingNav") {
        var shadow = document.getElementById("ShadowLayer");
        shadow.style.opacity = "0";
        shadow.style.pointerEvents = "none";
    }
}
function scrollToDetail() {
    var elmnt = document.getElementById("ProductDetail");
    elmnt.scrollIntoView();

  }
function scrollXLeft(carouselId){
    var slide = document.getElementById(carouselId);
    slide.scrollLeft += 300;
}
function scrollXRight(carouselId){
    var slide = document.getElementById(carouselId);
    slide.scrollLeft -= 300;
}
function backToTop(){
    document.documentElement.scrollTop = 0;
}
function openSelection(selectionID){
    var selection = document.getElementById(selectionID);
    if(selection.style.display == "block"){
        selection.style.display = "none";
    }
    else{
        selection.style.display = "block";
    }
  
}