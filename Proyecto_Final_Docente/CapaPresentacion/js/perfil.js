const close = document.getElementById("close");
const form = document.querySelector("form");
const div = document.querySelector("div#info");
const add = document.querySelector("div#Discapacidad");
const open = document.getElementById("addDiscapacidad");

open.addEventListener("click",()=>{
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
