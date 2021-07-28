var direcaoYJogador, direcaoXJogador, jogador, velJogador, posJogX,posJogY;
var tamTelaWidth, tamTelaHeight;
var velTiro, velBomba // controla a velocidade do tiro;
var contBombas, painelContBombas //contador e contralador do painel Bombas
var bombasTotal //recebe todos elementos da classe bomba
var vidaPlaneta //
var tempoCriaBomba // recebe ointervalo de criação da bomba
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
        atira(posJogX + 17, posJogY);
    }
}
function teclaUp()
{
    let tecla = event.keyCode;
    if (tecla == 38 || 40) //esquerda
    {
        direcaoYJogador = 0
    }
    if (tecla == 37 || 39) //direita
    {
        direcaoXJogador = 0
    }   
}

function criaBomba()
{
    if(jogo)
    {
        let posTiroY = 0;
        let posTiroX = Math.random() * tamTelaWidth;
        let bomba = document.createElement("div");
        let bombaAtributoUm = document.createAttribute("class");
        let bombaAtributoDois = document.createAttribute("style");
        bombaAtributoUm.value = "bombas";//Definindo nome da classe
        bombaAtributoDois.value = "top:" + posTiroY + "px;left:" + posTiroX + "px;"
        bomba.setAttributeNode(bombaAtributoUm);
        bomba.setAttributeNode(bombaAtributoDois);
        document.body.appendChild(bomba);
        contBombas--;
    }
}
function controlaBomba()
{
    bombasTotal = document.getElementsByClassName("bombas");
    let tamanho = bombasTotal.length;
    for (let i = 0; i < tamanho; i++)
    {
        if(bombasTotal[i])
        {
            let posBombaIndex = bombasTotal[i].offsetTop;
            posBombaIndex += velBomba;
            bombasTotal[i].style.top = posBombaIndex + "px";
            if(posBombaIndex > tamTelaHeight)
            {
                vidaPlaneta -= 10;
                bombasTotal[i].remove();
            }
        }
    }
}
function colisaoTiroBomba(tiro)
{
    tamanho = bombasTotal.length;
    for(let i = 0; i < tamanho;i++)
    {
        if(bombasTotal[i])
        {
            if
            (
                (//Verificação do eixo Y
                    (tiro.offsetTop <= (bombasTotal[i].offsetTop + 40))&& //Parte de cima do tiro com baixo bomba
                    ((tiro.offsetTop + 6) >= (bombasTotal[i].offsetTop)) //Baixo do tiro com cima da bomba
                )
                && //verificação do eixo X
                (
                    (tiro.offsetLeft <= (bombasTotal[i].offsetLeft +24) ) && //Esquerda do tiro com parte direita da bomba
                    ((tiro.offsetLeft + 6 ) >= (bombasTotal[i].offsetLeft)) //direita do tiro com a parte esquerda da bomba
                )
            )
            {
                bombasTotal[i].remove();
                tiro.remove();
            }
        }
    }

}

function atira(x , y)//recebe parametros da posição do jogador
{
    let tiro = document.createElement("div");
    let atributoUm = document.createAttribute("class");
    let atributoDois = document.createAttribute("style");
    atributoUm.value = "tiroJogador";
    atributoDois.value = "top:" + y +"px; left:" + x +"px";     
    tiro.setAttributeNode(atributoUm);
    tiro.setAttributeNode(atributoDois);
    document.body.appendChild(tiro);

}

function controleTiros()
{
    let tiros = document.getElementsByClassName("tiroJogador");
    let tamanhoTiros = tiros.length;
    for( let i = 0; i < tamanhoTiros; i++)
    {
        if (tiros[i])//SE verdadeiro significa que o tiro existe
        {
            let posTiro = tiros[i].offsetTop; //OffsetTop pega a posição do tiros
            posTiro -= velTiro;
            tiros[i].style.top = posTiro + "px";
            colisaoTiroBomba(tiros[i]);

            if (posTiro < 0)
            {
                //removendo tiros tem 2 formas
                document.body.removeChild(tiros[i]);
                //tiros[i].remove();
            }
        }
    }
}

function controlaJogador()//movimenta o jogador
{
    posJogY += direcaoYJogador * velJogador;
    posJogX += direcaoXJogador * velJogador;
    jogador.style.top = posJogY + "px";
    jogador.style.left = posJogX + "px";
}

function gameLoop()
{
    if(jogo)
    {
        //Funções de controle do jogo 
        controlaJogador();
        controleTiros();
        controlaBomba()
    }

    frames = requestAnimationFrame(gameLoop);
}
function inicia()//inicializa todos os componentes do game
{
    jogo = true;
    
    //Inicialização da tela 
    tamTelaHeight = window.innerHeight;
    tamTelaWidth = window.innerWidth;
    //inicialização jogador
    direcaoXJogador = direcaoYJogador = 0;
    posJogX = tamTelaWidth / 2;
    posJogY = tamTelaHeight / 2;
    velJogador = 5;
    velTiro = 5;
    jogador = document.getElementById("naveJogador");
    jogador.style.top = posJogY + "px";
    jogador.style.left = posJogX + "px";

    //Controles da Bombas
    clearInterval(tempoCriaBomba)
    contBombas = 150;
    velBomba = 3;
    //Intervalo das bombas
    tempoCriacao = 4000;
    tempoCriaBomba = setInterval(criaBomba,tempoCriacao);

    //controles do Planeta
    vidaPlaneta = 300;
    
    //Game Loop do Jogo;
    gameLoop()
}
window.addEventListener("load",inicia)
document.addEventListener("keydown",teclaDown);
document.addEventListener("keyup",teclaUp);

