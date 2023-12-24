const id = (name) => document.getElementById(name);
const clas = (name) => document.querySelectorAll(name);
const one = (name) => document.querySelector(name);
const btn = id("cambio");
const capa = id("capa");
const inputs = clas("input");
const toggle = clas(".toggle-panel");
const select = one("select");

btn.addEventListener("click", (e) => {
  e.preventDefault();

  btn.value = btn.value === "Sign up" ? "Sign in" : "Sign up";

  capa.classList.contains("activo")
    ? capa.classList.remove("activo")
    : capa.classList.add("activo");

  for (const inp of inputs) {
    if (inp.type !== "submit") {
      inp.value = "";
    }
  }
  for (const tog of toggle) {
    tog.classList.contains("hidden")
      ? tog.classList.remove("hidden")
      : tog.classList.add("hidden");
  }
  select.selectedIndex = 0;
});

function registro() {
  if (id("ddltipo").value === "DNI") {
    if (!/^\d{8}$/.test(id("txtdocumento").value)) {
      return false;
    }
  } else {
    if (!/^\d{12}$/.test(id("txtdocumento").value)) {
      return false;
    }
  }
  if (ValidarDatosP(id("txtnombre"), id("txtpaterno"), id("txtmaterno")))
    return false;

  if (
    /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/.test(
      id("txtcorreo").value.trim(),
    )
  )
    return false;
  if (
    id("txtpassword").value.length() > 4 &&
    id("txtpassword").value.length() <= 10
  )
    return false;

  alert("todo bien")
  return true;
}

function ValidarDatosP(name, aP, aM) {
  return /^[a-zA-Z]+(\s[a-zA-Z]+)*$/.test(name.trim()) &&
    /^[A-Z][a-z]*$/.test(aP.trim()) &&
    (/^[A-Z][a-z]*$/.test(aM.trim()) || aM.trim() === "");
}
