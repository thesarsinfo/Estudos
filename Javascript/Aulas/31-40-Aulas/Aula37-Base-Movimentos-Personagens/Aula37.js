let dx, dy,px,py,vel,obj,timer;
function Iniciar() {
    dx = 0;
    dy = 0;
    px = 0;
    py = 0;
    vel = 10;
    obj = document.getElementById("dv1");
    document.addEventListener("keydown",TeclaDown);
    document.addEventListener("keyup",TeclaUp);
    timer = setInterval(EnterFrame,20);
}
function TeclaDown() 
{
    let tecla = event.keyCode;
    if(tecla == 37)
   {
       dx = -1
   } else if (tecla == 38)
   {
        dy = -1
   } else if (tecla == 39)
   {
        dx = 1
   } else if(tecla == 40)
   {
        dy = 1
   }
}
function TeclaUp() 
{
    let tecla = event.keyCode;
    if(tecla == 37)
   {
       dx = 0;
   } else if (tecla == 38)
   {
        dy = 0;
   } else if (tecla == 39)
   {
        dx = 0;
   } else if(tecla == 40)
   {
        dy = 0;
   }
}
function EnterFrame()
{
    px += dx*vel;
    py += dy*vel;
    obj.style.left = px + "px";
    obj.style.top = py + "px";
}

window.addEventListener("load", Iniciar);