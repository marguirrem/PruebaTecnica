function mostrarRiesgo(numero) {
    edad = parseInt(numero);
    if (edad > 17 && edad <26) {
        document.getElementById("salvo").style.display = "block";
    }
    if (edad > 25 && edad < 51) {
        document.getElementById("media").style.display = "block";
    }
    if (edad > 50) {
        document.getElementById("tercera").style.display = "block";
    }
}