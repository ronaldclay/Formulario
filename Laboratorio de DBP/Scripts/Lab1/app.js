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

function verifyAjax(nombre, apellido) {
    var jsonData = {
        nombre: nombre,
        apellido: apellido
    };
    $.ajax({
        url: 'FormulariEstudent.aspx/recibirJSON',
        type: 'POST',
        async: true,
        data: JSON.stringify(jsonData),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: exito,
    });
    return false;
}

function exito(data) {
    var returnS = data.d;
    $('#contenidoServidor').text(returnS);
    $('#divServidor').css("display", "block");
    $('#contenidoServidor').removeClass('bg-danger bg-success');
    if (returnS[0] == "0") { 
        $('#contenidoServidor').addClass('bg-danger');

    } else {
        $('#contenidoServidor').addClass('bg-success');
    }
    return false;
}

let nombre;
let apellido;
function OnInput() {
    nombre = document.getElementById('Nombre').value;
    apellido = document.getElementById('Apellido').value;
    verifyAjax(nombre, apellido);
    console.log("Nombre:", nombre);
    console.log("Apellido:", apellido);
}
document.getElementById('Apellido').addEventListener('input',OnInput);