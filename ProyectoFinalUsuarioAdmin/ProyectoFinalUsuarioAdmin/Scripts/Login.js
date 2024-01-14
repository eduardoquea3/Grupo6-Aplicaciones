function togglePasswordVisibility() {
    var passwordField = document.getElementById("passwordField");
    var toggleIcon = document.getElementById("toggleIcon");

    // Verifica si el tipo de campo es "password"
    if (passwordField.type === "password") {
        // Cambia el tipo de campo a "text" para mostrar la contraseña
        passwordField.type = "text";
        toggleIcon.innerHTML = '<i class="fa-solid fa-eye-slash"></i>'; // Cambia el ícono a ojo tachado
    } else {
        // Cambia el tipo de campo a "password" para ocultar la contraseña
        passwordField.type = "password";
        toggleIcon.innerHTML = '<i class="fa-solid fa-eye"></i>'; // Cambia el ícono a ojo
    }
}