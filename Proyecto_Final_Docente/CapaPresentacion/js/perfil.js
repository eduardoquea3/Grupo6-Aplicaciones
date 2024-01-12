const id = (n) => document.getElementById(n)
const one = (n) => document.querySelector(n)
const mul = (n) => document.querySelectorAll(n)
const close = id("close");
const open = id("addDiscapacidad");
const form = one("form");
const div = one("div#info");
const add = one("div#Discapacidad");

open.addEventListener("click", () => {
  add.classList.toggle("hidden")
  div.classList.toggle("hidden")
  div.classList.toggle("container")
  form.classList.toggle("nb")
})
close.addEventListener("click", (e) => {
  e.preventDefault();
  form.classList.toggle("nb")
  add.classList.toggle("hidden")
  div.classList.toggle("hidden")
  div.classList.toggle("container")
});

const inicio = id("inicio");
const perfil = id("perfil");
const academico = id("academico");
const experiencia = id("experiencia");
const cursos = id("cursos");

function redirection(control, page) {
  let id = new URLSearchParams(window.location.search).get("id");
  control.href = page + "?id=" + id;
}

inicio.addEventListener("click", redirection(inicio, "Inicio.aspx"));
perfil.addEventListener("click", redirection(perfil, "Perfil.aspx"));
academico.addEventListener("click", redirection(academico, "Academico.aspx"));
experiencia.addEventListener(
  "click",
  redirection(experiencia, "Experiencia.aspx"),
);
cursos.addEventListener("click", redirection(cursos, "Cursos.aspx"));

id("menu").addEventListener("click", () => {
  const sidebar = document.getElementById("sidebar");
  const contenido = document.getElementById("contenido");

  if (sidebar.style.width === "16rem") {
    sidebar.style.width = "4rem";
  } else {
    sidebar.style.width = "16rem";
  }
  contenido.classList.toggle("ml-[4rem]");
  contenido.classList.toggle("ml-[16rem]");
  const labels = sidebar.querySelectorAll("span");
  labels.forEach((label) => label.classList.toggle("hidden"));
})

function validarDisc() {
  console.log("inicio")
  add.classList.toggle("hidden")
  div.classList.toggle("hidden")
  div.classList.toggle("container")
  form.classList.toggle("nb")
  if (id("ContentPlaceHolder1_txtdiscapacidad").value.trim() == "") {
    return false
  }
  else if (id("ContentPlaceHolder1_txtdescripcion").value.trim() == "") {
    return false
  }
  console.log("fin")
  return true
}

function mostrarImagen(input) {
  if (input.files && input.files[0]) {
    let leer = new FileReader();
    leer.onload = function (e) {
      document.getElementsByTagName("img")[0].setAttribute("src", e.target.result);
    }
    leer.readAsDataURL(input.files[0]);
  }
}


/* const tipo = id("ContentPlaceHolder1_ddltipo")
const doc = id("ContentPlaceHolder1_txtdocumento")
function validarDatos() {
  if (tipo.selectedIndex == 0) {
    if (doc.trim().length != 8) {
      return false
    }
  }
  else {
    if (doc.trim().length != 12)
      return false
  }
  if (!validarTexto())
    return false
  alert("hola")
  return true
}


/* function validarTexto() { */
/*   const texto = mul("input[type='text'].login")
  texto.forEach((e) => {
    if (e.value.trim().length == 0) {
      return false
    }
  })
} */