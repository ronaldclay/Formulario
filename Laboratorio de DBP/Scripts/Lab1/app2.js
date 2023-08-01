function ButtonMostrar() {
    
    let cookies = document.cookie.split(';');
    let valor1, valor2;
    for (let i = 0; i < cookies.length; i++) {
        let cookie = cookies[i].trim();
        if (cookie.startsWith('user_sexo=')) {
            valor1 = cookie.substring('user_sexo='.length);
        } else if (cookie.startsWith('user_ciudad=')) {
            valor2 = cookie.substring('user_ciudad='.length);
        }
    }
    document.getElementById("areaCookie").value = "UserInfo:\n Sexo: " + valor1 + "\nCiudad: " + valor2;
    return false;
}
