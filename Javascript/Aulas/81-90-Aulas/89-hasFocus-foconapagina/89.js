setInterval(foco,500);
function foco()
{
    let resultado = document.getElementById("verificaFoco");
    let painel = document.getElementById("painel");
    if(document.hasFocus())
    {
        resultado.innerHTML = "";
        painel.style.display = "none";
    }
    else
    {
        resultado.innerHTML = ">> NÂO <<";
        painel.style.display = "block";
    }

}