/* 
Aula 39 request animated frame quem faz o gerenciamento ´o browser
e não prescisa se preocupa com tempo de controle de animação
*/

let jogador, velocidade, deslocamentoX, descolamentoY;
let posicaoX, posicaoY, anima;

function inicia() 
{
    velocidade = 5;
    deslocamentoX = 1;
    descolamentoY = 0;
    posicaoX = 0;
    posicaoY = 0;
    jogador = document.getElementById("jogador");
    jogador.addEventListener("click", function()
    {
        cancelAnimationFrame(anima);
    })
    game();
}
function game() 
{
    posicaoX += (deslocamentoX * velocidade);
    //posicaoY += (descolamentoY * velocidade);
    jogador.style.left = posicaoX +"px";
    //jogador.style.top = posicaoY +"px";
    if (posicaoX > 300)
    {
        deslocamentoX = -1;
    } else if (posicaoX < 0)
    {
        deslocamentoX = 1;
    }
    anima = requestAnimationFrame(game);  
}

window.addEventListener("load",inicia);