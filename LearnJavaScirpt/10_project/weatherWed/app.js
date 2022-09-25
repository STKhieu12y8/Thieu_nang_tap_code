const input = document.querySelector('.input_town')
const town = document.querySelector('.town')
const time = document.querySelector('.time-date')
const temperature = document.querySelector('.temperature')
const sky = document.querySelector('.sky')
const eye = document.querySelector('.eye')
const winds = document.querySelector('.winds')
const humidity = document.querySelector('.humidity')
input.addEventListener('keydown', function (e) {
    if (e.key === 'Enter' && e.target.value.trim() != "") {
        ChangeWeatherUI(e.target.value)
        input.blur()
    }
})
async function ChangeWeatherUI(cityName) {
    let o = `https://api.openweathermap.org/data/2.5/weather?q=${cityName}&appid=c2585c35ff107198c5006ebf027d06ff&units=metric&lang=vi`
    let data = await fetch(o).then(res => res.json())
    if (data.cod == 200) {
        town.innerText = data.name
        setInterval(() => {
            time.innerText = new Date().toLocaleString('vi')
        }, 1000)
        temperature.innerText = Math.floor(data.main.temp) + "°C"
        sky.innerText = data.weather[0].description
        eye.innerText = data.weather[0].id + "m"
        winds.innerText = data.wind.speed + "m/s"
        humidity.innerText = data.main.humidity + "%"
    }
    else {
        alert("Bạn vui lòng nhập đúng thành phố")
        input.focus()
    }
}
