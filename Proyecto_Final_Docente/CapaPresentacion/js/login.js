const id = (name) => document.getElementById(name)
const clas = (name) => document.querySelectorAll(name)
const one = (name) => document.querySelector(name)
const btn = id("cambio")
const capa = id("capa")
const inputs = clas("input")
const toggle = clas(".toggle-panel")
const select = one("select")

btn.addEventListener("click", (e) => {
    e.preventDefault()

    btn.value=="Sign up"?btn.value="Sign in":btn.value="Sign up"

    capa.classList.contains("activo") ? capa.classList.remove("activo") : capa.classList.add("activo")

    inputs.forEach((inp) => {
        if (inp.type != "submit") {
            inp.value = ""
        }
    })
    toggle.forEach((tog) => {
        tog.classList.contains("hidden") ? tog.classList.remove("hidden") : tog.classList.add("hidden")
    })
    select.selectedIndex = 0
})
