let painel;

function localizar(posicao)
{
    let coordenadas =  posicao.coords;
    painel.innerHTML += "Localização: Latitude: " + coordenadas.latitude + " - Longitude: "
     + coordenadas.longitude + "<hr>";
}
function errorr()
{
    alert("GPS desabilitado");
    console.log("GPS Desabilitado");
    painel.innerHTML += "Localização: GPS desabilitado " + "<hr>"
}

function verifica()
{
painel = document.getElementById("painel");
//propriedades importantes do navigator

// Retorna o nome do browser
painel.innerHTML += "Nome do Browser: " + navigator.appName + "<hr>"; /* retorna netscape ahuahauhauh
*/
painel.innerHTML += "Versão do Browser: " + navigator.appVersion + "<hr>";
painel.innerHTML += "Cookies: " + navigator.cookieEnabled + "<hr>";
navigator.geolocation.getCurrentPosition(localizar,errorr) + "<hr>";
painel.innerHTML += "Idioma do Browser: " + navigator.language + "<hr>";
painel.innerHTML += "Online: " + navigator.onLine + "<hr>";
painel.innerHTML += "Sistema operacional: " + navigator.platform + "<hr>";
painel.innerHTML += "Engine: " + navigator.product + "<hr>";
painel.innerHTML += "Agente: " + navigator.userAgent + "<hr>";
}
window.addEventListener("load",verifica);