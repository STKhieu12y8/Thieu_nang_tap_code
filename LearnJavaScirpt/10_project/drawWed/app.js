const color = document.querySelector('.color')
const eraser = document.querySelector('.eraser')
const deincrease = document.querySelector('.deincrease')
const increase = document.querySelector('.increase')
const size = document.querySelector('.size')
const save = document.querySelector('.save')
const close = document.querySelector('.close')
var canvas = document.getElementById('canvas')
var ctx = canvas.getContext('2d')

var pos1 = {
    x: 0,
    y: 0,
}
var isDrawing = false
var colorStyle = "black"
var width = 10
size.innerHTML = `${width}`




canvas.addEventListener("mousedown", function (e) {
    pos1 = {
        x: e.offsetX,
        y: e.offsetY
    }
    isDrawing = true
})

document.addEventListener("mousemove", function (e) {
    console.log(pos1.x, pos1.y)
    if (isDrawing) {
        pos2 = {
            x: e.offsetX,
            y: e.offsetY
        }

        ctx.beginPath()
        ctx.arc(pos1.x, pos1.y, width, 0, 2 * Math.PI)
        ctx.stroke()

        ctx.beginPath()
        ctx.moveTo(pos1.x, pos1.y)
        ctx.lineTo(pos2.x, pos2.y)
        ctx.strokeStyle = colorStyle
        ctx.lineWidth = width*2
        ctx.stroke()


        pos1.x = pos2.x
        pos1.y = pos2.y
    }
})

document.addEventListener("mouseup", function (e) {
    isDrawing = false
})

color.addEventListener('change', function (e) {
    colorStyle = e.target.value
    console.log(colorStyle)
})

eraser.addEventListener("click", function (e) {
    colorStyle = "#ffffff"
})

deincrease.addEventListener('click', function () {
    width -= 1
    width = width > 5 ? width: 5
    size.innerHTML = `${width}`
})

increase.addEventListener('click', function () {
    width += 1
    width = width < 30 ? width: 30
    size.innerHTML = `${width}`

})

close.addEventListener('click', function () {
    let canvasStart = canvas.getClientRects()[0]
    ctx.clearRect(0, 0, canvasStart.width, canvasStart.height)
})

save.addEventListener('click', function () {
    let file = canvas.toDataURL('image/png')
    save.setAttribute('href', file)
})