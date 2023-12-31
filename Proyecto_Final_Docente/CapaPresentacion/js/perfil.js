const id = (n) => document.getElementById(n)
const one = (n) => document.querySelector(n)
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
