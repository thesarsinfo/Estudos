function Relogio()
{
    let data = new Date();
    let horas = data.getHours();
    let minutos = data.getMinutes();
    let segundos = data.getSeconds();
    horas = (horas < 10)? "0" + horas : horas;
    minutos = (minutos < 10)? "0" + minutos : minutos; 
    segundos = (segundos < 10)? "0" + segundos: segundos;    
    let horasFormatada = horas + ":" + minutos + ":" + segundos;
    document.getElementById("rel").value = horasFormatada;
}
setInterval(Relogio, 1000);