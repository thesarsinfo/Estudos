var direcaoYJogador, direcaoXJogador, jogador, velJogador, posJogX,posJogY;
var tamTelaWidth, tamTelaHeight;
var jogo; //controle o jogo rodando
var frames; //usado em requestanimation frame


function teclaDown()
{
    let tecla = event.keyCode;
    if (tecla == 37) //esquerda
    {
        direcaoXJogador = -1
    }
    else if (tecla == 39) //direita
    {
        direcaoXJogador = 1
    }
    if (tecla == 38) //cima
    {
        direcaoYJogador = -1
    }    
    else if (tecla == 40) //baixo
    {
        direcaoYJogador = 1
    }
    if (tecla == 32)//espaço // tiro
    {
        //função tiro
    }
}
function teclaUp()
{
    let tecla = event.keyCode;
    if (tecla == 38 || 40) //esquerda
    {
        direcaoYJogador = 0
    }
    else if (tecla == 37 || 39) //direita
    {
        direcaoXJogador = 0
    }   
}

function controlaJogador()//movimenta o jogador
{
    posJogY
}

function gameLoop()
{
    if(jogo)
    {
        //Funções de controle do jogo 
    }

    frames = requestAnimationFrame(gameLoop);
}
function inicia()//inicializa todos os componentes do game
{
    jogo = false;
    
    //Inicialização da tela 
    tamTelaHeight = window.innerHeight;
    tamTelaWidth = window.innerWidth;
    //inicialização jogador
    direcaoXJogador = direcaoYJogador = 0;
    posJogX = tamTelaWidth / 2;
    posJogY = tamTelaHeight / 2;
    velJogador = 5;
    jogador = document.getElementById("naveJogador");
    jogador.style.top = posJogY + "px";
    jogador.style.left = posJogX + "px";
}
window.addEventListener("load",inicia)
document.addEventListener("keydown",teclaDown);
document.addEventListener("keyup",teclaUp);

