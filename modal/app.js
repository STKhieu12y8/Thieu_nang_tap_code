let modal_show = document.querySelector(".modal");
let iconClose = document.querySelector(".close");
let btnClose = document.querySelector(".btn_close")
let container = document.querySelector(".modal_container")
let background_close = document.querySelector(".modal_background")

function show () {
    container.classList.add('open');
}
function hide () {
    container.classList.remove('open');
}

modal_show.addEventListener("click", show);

iconClose.addEventListener("click", hide);

btnClose.addEventListener("click", hide);

//background_close.addEventListener("click", hide);