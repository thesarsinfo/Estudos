/* 
Adiciona um escutador onde melhora a organzação do código
elemento.addeventlistener(evento, função)
*/
function msg()
{
    alert("Saraiva Estudos");
}
function cor(obj,cor)
{
    obj.style.backgroundColor = cor;
}
function cor2()
{
    let div = document.getElementById('dv1');
    div.style.backgroundColor = "#f00";
}

function addEventos()
{
    let div = document.getElementById('dv1');
    div.addEventListener("click",msg);
    //Com parametro
    div.addEventListener("mouseover", function(event)
    {
            //objeto, cor        
        cor(div,"#fff");
    });
    //sem parametro
    div.addEventListener("mouseout", cor2 )
}
window.addEventListener("load", addEventos);