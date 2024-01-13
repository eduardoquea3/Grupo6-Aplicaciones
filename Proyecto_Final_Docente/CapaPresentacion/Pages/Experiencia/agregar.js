const id = n => document.getElementById(n)
function validar() {
    if (id("txtfinicio").value == "")
        return false
    if (id("txtffin").value == "")
        return false
    if (id("txtcargo").value.trim() == "")
        return false
    if (id("txtempresa").value.trim() == "")
        return false
    alert("Ingresado con exito")
    return true
}