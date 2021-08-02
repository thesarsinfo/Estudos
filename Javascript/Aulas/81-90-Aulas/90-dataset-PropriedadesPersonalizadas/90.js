
function definePainel()
{
    let obj = event.target
    let painel = document.getElementById("painel");
    painel.innerHTML = "Modelo: " + obj.dataset.modelo + "<br>";
    painel.innerHTML += "Cor: " + obj.dataset.cor + "<br>";
    painel.innerHTML += "Potência: " + obj.dataset.potencia + " cv <br>";
    painel.innerHTML += "Velocidade Máxima: " + obj.dataset.velocidade + " km/h <br>";    
}

function inicia()
{
    document.getElementById("c1").addEventListener("click",definePainel);
    document.getElementById("c2").addEventListener("click",definePainel);
    document.getElementById("c3").addEventListener("click",definePainel);
    document.getElementById("c4").addEventListener("click",definePainel);
}
window.addEventListener("load",inicia);