const Nombre = document.getElementById("Nombre");
const Apellido = document.getElementById("Apellido");
const Email = document.getElementById("Email");
const Masculino = document.getElementById("botonMasculino");
const Femenino = document.getElementById("botonFemenino");
const Direccion = document.getElementById("Direccion");
const Ciudad = document.getElementById("ListaCiudad");
const Requirimiento = document.getElementById("Requirimiento");
const modal = document.getElementById("nkf");
function closeuwu() {
    while (modal.childNodes[1]) {
        modal.removeChild(modal.childNodes[1]);
    }
}
function limpiar() {
    let vacio = "";
    Nombre.value = vacio;
    Apellido.value = vacio;
    Masculino.checked = false;
    Femenino.checked = false;
    Email.value = vacio;
    Direccion.value = vacio;
    Ciudad.selectedIndex = 0;
    Requirimiento.value = vacio;
    return false;
}
const ExpRegulares = {
    Nombre: /^[a-zA-Z]+$/,
    Apellido: /^[a-zA-Z ]+$/,
    correo: /^[a-zA-Z0-9._%+-]+@unsa\.edu\.pe$/,
}
function enviar() {
    let time = new Date();

    if (!ExpRegulares.Nombre.test(Nombre.value)) {
        const texto = document.createElement("p");
        texto.textContent = "Error en nombre";
        modal.appendChild(texto);
        return false;
    }
    if (!ExpRegulares.Apellido.test(Apellido.value)) {
        const texto = document.createElement("p");
        texto.textContent = "Error de apellido";
        modal.appendChild(texto);
        return false;

    }
    if (Masculino.checked == false) {
        if (Femenino.checked == false) {
            const texto = document.createElement("p");
            texto.textContent = "Sexo no indicado";
            modal.appendChild(texto);
            return false;
        }
    }
    if (!ExpRegulares.correo.test(Email.value)) {
        const texto = document.createElement("p");
        texto.textContent = "Error en el correo";
        modal.appendChild(texto);
        return false;
    }
    if (Ciudad.selectedIndex == 0) {
        const texto = document.createElement("p");
        texto.textContent = "Seleccionar ciudad";
        modal.appendChild(texto);
        return false;
    }
    const texto = document.createElement("p");
    let v = `registrado a las: ${time.toLocaleString()}`;
    texto.textContent = v;
    modal.appendChild(texto);
    alert(`registrado a las: ${time.toLocaleString()}`);
    return true;
}