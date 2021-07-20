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
let posAtualCpuX, posAtualCpuY;

//Direção
let direcaoJogadorY;

//Posições Iniciais
let posJogoJogadorInicialX = 10 ,posJogoJogadorInicialY = 180
let posJogoCpuInicialX = 930, posJogoCpuInicialY  = 180
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

function controlaJogador()
{
    if(jogo)
    {
        posAtualJogadorY += velocidadeJogador * direcaoJogadorY;
        ((posAtualJogadorY + barraHeight ) >= campoHeight ||(posAtualJogadorY <= 0 ))
        ? inverteMovimento() : dvJogador.style.top = posAtualJogadorY + "px";               
    }
}
function inverteMovimento()
{
    posAtualJogadorY += (velocidadeJogador * direcaoJogadorY) * -1;   
}
function teclaDown() // Tecla pressionada sem soltar do jogador
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
function teclaUp() // Tecla solta do jogador
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

function controlaBola()
{
    //Movimentação da bola
    posAtualBolaX += velocidadeBola * bolaX;
    posAtualBolaY += velocidadeBola * bolaY;
    //Colisão com jogador
    if
    (
        (posAtualBolaX <= posAtualJogadorX + barraWidth ) &&
        ((posAtualBolaY + bolaHeight >= posAtualJogadorY) && (posAtualBolaY <= posAtualJogadorY + barraHeight ))
    )
    {
        bolaY = (((posAtualBolaY+(bolaHeight / 2)) - (posAtualJogadorY + (barraHeight /2)))/16);
        bolaX *=  -1;
    }
   
    //Colisão com CPU
    if
    (
        (posAtualBolaX >= posAtualCpuX - barraWidth ) &&
        ((posAtualBolaY + bolaHeight >= posAtualCpuY) && (posAtualBolaY <= posAtualCpuY + barraHeight ))
    )
    {
        bolaY = (((posAtualBolaY+(bolaHeight / 2)) - (posAtualCpuY + (barraHeight /2)))/16);
        bolaX *= -1;
    }
    //Colisão com campo inferior e superior
    if ((posAtualBolaY >= 480 || posAtualBolaY <= 0))
    {
        bolaY *= -1; 
    }
    //Gol do playey ou CPU esquerda ou direita
    if (posAtualBolaX >= (campoWidth - bolaWidth))
    {
        velocidadeBola = 0;
        posAtualBolaX = posBolaInicialX;
        posAtualBolaY = posBolaInicialY;
        posAtualJogadorY = posJogoJogadorInicialY;
        posAtualCpuY = posJogoCpuInicialY;
        jogadorPontos++;
        dvJogadorPontos.value = jogadorPontos;
        dvJogador.style.top = posAtualJogadorY + "px";
        dvCpu.style.top = posAtualCpuY + "px";
        jogo = false;
    }
    else if  (posAtualBolaX <= 0)
    {
        velocidadeBola = 0;
        posAtualBolaX = posBolaInicialX;
        posAtualBolaY = posBolaInicialY;
        posAtualJogadorY = posJogoJogadorInicialY;
        posAtualCpuY = posJogoCpuInicialY;
        cpuPontos++;
        dvCpuPontos.value = cpuPontos;
        dvJogador.style.top = posAtualJogadorY + "px";
        dvCpu.style.top = posAtualCpuY + "px";
        jogo = false;
    }

    dvBola.style.left = posAtualBolaX + "px";
    dvBola.style.top = posAtualBolaY + "px";
}
function sorteiaLadoInicial()
{
    return bolaX = ((Math.random()*10) < 5)? -1 : +1;    
}
//Controle da cpu
function controlaCPU()
{
    if(jogo)
    {
        if
        ((posAtualBolaX > (campoWidth / 2)) &&(bolaX > 0))
        {
            //Movimentar Cpu
            if ( (posAtualBolaY + (bolaHeight / 2) ) > (posAtualCpuY + (barraHeight / 2)) + velocidadeCpu)
            {
                //Mover para baixo
                if
                ((posAtualCpuY + barraHeight) <= campoHeight)
                {
                    posAtualCpuY += velocidadeCpu
                }
            }
            else if 
            ((posAtualBolaY + (bolaHeight / 2)) < (posAtualCpuY + (barraHeight / 2)) + velocidadeCpu)
            {
                //Mover para cima
                if(posAtualCpuY >= 0)
                {
                    posAtualCpuY -= velocidadeCpu
                }
            }
        }
        else
        {
            //posicionar a CPU no centro
            if
            ((posAtualCpuY + (barraHeight / 2) ) < (campoHeight / 2))
            {
                posAtualCpuY += velocidadeCpu;
            }
            else if ((posAtualCpuY + (barraHeight / 2) ) > (campoHeight / 2))
            {
                posAtualCpuY -= velocidadeCpu;
            }
        }
        dvCpu.style.top = posAtualCpuY + "px";
    }
    
}

//Loop do Jogo

function games()
{
    if(jogo)
    {
        controlaJogador();
        controlaBola();
        controlaCPU();
    }
    frames = requestAnimationFrame(games);
}

//Carrega Variaveis Globais do jogo e chama função de loop
function iniciaJogo()
{
    if(!jogo)
    {
        cancelAnimationFrame(frames);
        velocidadeBola = velocidadeCpu = velocidadeJogador = 8;
        jogo = true;
        direcaoJogadorY = 0; //NEgativo sobe e positivo desce
        bolaX = sorteiaLadoInicial();
        bolaY = 0;
        posAtualBolaX = posBolaInicialX;
        posAtualBolaY = posBolaInicialY;
        posAtualJogadorX = posJogoJogadorInicialX;
        posAtualJogadorY = posJogoJogadorInicialY;
        posAtualCpuX = posJogoCpuInicialX
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