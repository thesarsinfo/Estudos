let px = 0;
let py = 0;
let obj;

function move()
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
       document.removeEventListener("keydown", move);       
       document.addEventListener("click",addClique);
   }
}

function addClique()
{
    document.addEventListener("keydown",move);
    obj.style.backgroundColor = "#f00";
}

function iniciar()
{
    obj = document.getElementById("dv1");
    obj.addEventListener("click",addClique);
}

window.addEventListener("load",iniciar);