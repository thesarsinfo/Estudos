/* 
Aula 34 para adicionar eventos na div e movimentar a div pelo 
teclado
*/
let px = 0;
let py = 0;
function move()
{
    let obj = document.getElementById("dv1");
    let tecla = event.keyCode;
    /* 37 = <- Esquerda
       38 = cima
       39 = direita
       40 = baixo
    */
       console.log(tecla);
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
        
   }
}
document.addEventListener("keydown", move)
