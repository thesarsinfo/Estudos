let px = 0;
let py = 0;

function ativaTeclas()
{ 
    document.removeEventListener("click", ativaTeclas);       
    document.addEventListener("keydown",moveTeclas);    
}
function moveTeclas()
{    
    let obj = document.getElementById("dv1");
    let tecla = event.keyCode;    
    if(tecla == 37)
   {   
        px -= 10;
        obj.style.left = px + "px";
   } else if (tecla == 38)
   {
        py -= 10;
        obj.style.top = py + "px";
   } else if (tecla == 39)
   {
        px += 10;
        obj.style.left = px + "px";
   } else if(tecla == 40)
   {
        py += 10;
        obj.style.top = py + "px";
   }else if(tecla == 13)
   {
       alert("Evento removido");
       document.removeEventListener("keydown", moveTeclas);       
       document.addEventListener("click",ativaTeclas)
   }
}
document.addEventListener("click",ativaTeclas)