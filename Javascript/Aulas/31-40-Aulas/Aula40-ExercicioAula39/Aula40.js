/* 
Aula 39 request animated frame quem faz o gerenciamento ´o browser
e não prescisa se preocupa com tempo de controle de animação
*/

let jogador, velocidade, deslocamentoX, descolamentoY;
let posicaoX, posicaoY, anima;
let btn1 , btn2, animacao;

function inicia() 
{   
    animacao = 1;
    btn1 = document.getElementById("btn1");
    btn2 = document.getElementById("btn2");    
    velocidade = 2;
    deslocamentoX = 1;
    descolamentoY = 0;
    posicaoX = 0;
    posicaoY = 0;

    jogador = document.getElementById("jogador");
   
           
    btn1.addEventListener("click",mover);
    btn2.addEventListener("click", parar)
    jogador.addEventListener("click", MoverParar); 
    
    
    game();
}
function MoverParar()
{
    if (animacao)
    {
        animacao = 0;
        jogador.style.backgroundColor = "#f00"
        cancelAnimationFrame(anima);
    }else
    {
        animacao = 1;
        jogador.style.backgroundColor = "#00f"
        anima = requestAnimationFrame(game);
    }
}
function mover()
{
    if (!animacao)
    {
        animacao = 1
        jogador.style.backgroundColor = "#00f"
        anima = requestAnimationFrame(game);
    }
}
function parar()
{    
    animacao = 0
    jogador.style.backgroundColor = "#f00"
    cancelAnimationFrame(anima);
    
}
function game() 
{          
    
    posicaoX += (deslocamentoX * velocidade);
    //posicaoY += (descolamentoY * velocidade);
    jogador.style.left = posicaoX +"px";
    //jogador.style.top = posicaoY +"px";
    if (posicaoX > 500)
    {
        deslocamentoX = -1;
    } else if (posicaoX < 0)
    {
        deslocamentoX = 1;
    }
    anima = requestAnimationFrame(game);  
    console.log(animacao)
    
}

window.addEventListener("load",inicia);