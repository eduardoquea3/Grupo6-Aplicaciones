function expandSidebar() {
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
}

const id = (n) => document.getElementById(n);

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
