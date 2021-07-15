/*
Recursividade uma função que chama ela mesma use com cautela
Qualquer rotina de loop pode ser substituida
*/

function Contador(min,max) //padrao para loop
{
    document.write(min +"<br>");
    if (min < max)
    {
        Contador(++min,max);//temos que incrementar antes senão entra em um loop infinito
    }
}
Contador(0,10)
function Fatorial(num)
{
    if (num == 1)
    {
        return 1;
    }
    return num*Fatorial(num - 1)
    
}
document.write(Fatorial(5));

let quadrado = document.getElementById("Quad");
console.log(quadrado);
let ang = 0;
let anima;
function gira()
{
    quadrado.style.transform = "rotate("+ang+"deg)";
    ang++;
    if(ang > 360)
    {
        ang = 0;
    } 
    anima =requestAnimationFrame(gira);
}

window.addEventListener("load",gira());