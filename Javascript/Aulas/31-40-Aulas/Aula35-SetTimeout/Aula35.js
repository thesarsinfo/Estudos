/*
settimeout e setinterval
settimeout faz a chamada de callback durante apos x tempo
setinterval recebe função callback e a cada ciclo e repete a função
clear interval serve para parar o setinterval;
*/
let timeInteval
function mudaCor()
{
    let obj = document.getElementById("dv1");
    let r = Math.floor(Math.random() * 255);
    let g = Math.floor(Math.random() * 255);
    let b = Math.floor(Math.random() * 255);
    obj.style.backgroundColor = "rgb("+r+","+g+","+b+")";
}
let timeOut = setTimeout(mudaCor,500);//3 seg

function iniciar()
{
    timeInteval = setInterval(mudaCor,1);//3 seg
}
function parar()
{
    clearInterval(timeInteval)
}

function addEventos()
{
    document.getElementById("bt1").addEventListener("click",iniciar);
    document.getElementById("bt2").addEventListener("click",parar);
}
window.addEventListener("load",addEventos);