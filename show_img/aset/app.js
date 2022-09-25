let close = document.querySelector('.close')

let images = document.querySelectorAll('.image img')

let pre = document.querySelector('.pev')

let next = document.querySelector('.next')

let gallerying = document.querySelector('.galery__img img')

let gallre = document.querySelector('.galery')

let currentIndex = 0

function gallryShow () {
    if (currentIndex == 0) {
        pre.classList.add('hiden')
    }
    else {
        pre.classList.remove('hiden')
    }

    if (currentIndex == (images.length - 1)) {
        next.classList.add('hiden')
    }
    else {
        next.classList.remove('hiden')
    }

    gallerying.src = images[currentIndex].src
    gallre.classList.add('show')
}

images.forEach((item, index) => {
    item.addEventListener("click", function() {
        currentIndex = index;
        gallryShow();
    })
})


close.addEventListener("click", function() {
    gallre.classList.remove('show')
})

document.addEventListener("keydown", function(e) {
    if (e.keyCode == 27) {
        gallre.classList.remove('show')
    }
})

pre.addEventListener("click", function(){
    if (currentIndex > 0) {
        currentIndex--;
        gallryShow();
    }
})

next.addEventListener("click", function() {
    if (currentIndex < (images.length - 1)) {
        currentIndex++;
        gallryShow();
    }
})