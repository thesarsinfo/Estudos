//Variaveis Globais
//Elementos
let btIniciar;
let dvBola
let dvCpu
let dvJogador;
let dvJogadorPontos
let dvCpuPontos


//Controle de Animação

let game, frames;

//Posições

let posAtualBolaX, posAtualBolaY;
let posAtualJogadorX, posAtualJogadorY;
let posCpuX, posAtualCpuY;

//Direção
let direcaoJogadorY;

//Posições Iniciais

let posicaoJogoInicialX = 180;
let posJogoJogadorInicialY = 180, posJogoCpuInicialY  = 180
let posBolaInicialX = 475, posBolaInicialY = 240;

//Tamanhos

let campoX=0,campoY = 0, campoWidth = 960, campoHeight = 500;
let barraWidth = 20, barraHeight = 140; bolaWidth = 20 , bolaHeight = 20;

//direção
let bolaX , bolaY;
let cpuY = 0;

//Velocidade

let velocidadeBola, velocidadeJogador, velocidadeCpu

//Controle
let jogadorPontos = 0, cpuPontos = 0;
let tecla;
let jogo = false // false jogo parado 

function controlaJogo()
{
    if(jogo)
    {
        posAtualJogadorY += velocidadeJogador * direcaoJogadorY;
        dvJogador.style.top = posAtualJogadorY + "px";
    }
}


function teclaDown() // Tecla pressionada sem soltar
{
    tecla = event.keyCode;
    if(tecla == 38)
    {
        direcaoJogadorY =- 1;
    }
    else if(tecla == 40)
    {
        direcaoJogadorY =+ 1;
    }
}
function teclaUp() // Tecla solta
{
    tecla = event.keyCode;
    if(tecla == 38)
    {
        direcaoJogadorY = 0;
    }
    else if(tecla == 40)
    {
        direcaoJogadorY = 0;
    }
}

function games()
{
    if(jogo)
    {
        controlaJogo();
    }
    frames = requestAnimationFrame(games);
}

function iniciaJogo()
{
    if(!jogo)
    {
        cancelAnimationFrame(frames);
        velocidadeBola = velocidadeCpu = velocidadeJogador = 8;
        jogo = true;
        direcaoJogadorY = 0; //NEgativo sobe e positivo desce
        posAtualBolaX = posBolaInicialX;
        posBolaInicialY = posAtualBolaY; 
        posAtualJogadorY = 180;
        posAtualCpuY = posJogoCpuInicialY;
        games()
    }
}

function inicializa()
{   
    
    btIniciar = document.getElementById("btIniciar");
    btIniciar.addEventListener("click",iniciaJogo);
    dvJogador = document.getElementById("dvJogador");
    dvBola = document.getElementById("dvBola");
    dvCpu = document.getElementById("dvCpu");
    dvCpuPontos = document.getElementById("txtCpuPontos");
    dvJogadorPontos = document.getElementById("txtJogadorPontos");
    //Eventos 
    document.addEventListener("keydown",teclaDown);
    document.addEventListener("keyup",teclaUp);


}
window.addEventListener("load",inicializa);