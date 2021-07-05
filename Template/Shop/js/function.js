function openNav() {
    var shadow = document.getElementById("ShadowLayer");
    var slideBar = document.getElementById("SlidingNav");
    slideBar.style.zIndex = "1";
    slideBar.style.opacity = "1";
    slideBar.style.transform = "none";
    slideBar.style.transition = "transform 0.3s ease-in-out 0s;"
    shadow.style.opacity = "1";
    shadow.style.pointerEvents = "auto";
}
function closeNav() {
    var slideBar = document.getElementById("SlidingNav");
    var shadow = document.getElementById("ShadowLayer");
    slideBar.style.zIndex = "0";
    slideBar.style.opacity = "0";
    slideBar.style.transform = "translate(100vw, 0px)";
    slideBar.style.transition = "opacity 0s linear 0.4s, transform 0.3s ease-in-out 0s";
    shadow.style.opacity = "0";
    shadow.style.pointerEvents = "none";
}