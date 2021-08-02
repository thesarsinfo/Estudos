var direcaoYJogador, direcaoXJogador, jogador, velJogador, posJogX,posJogY;
var tamTelaWidth, tamTelaHeight;
var velTiro, velBomba // controla a velocidade do tiro;
var contBombas, painelContBombas //contador e contralador do painel Bombas
var bombasTotal //recebe todos elementos da classe bomba
var vidaPlaneta //
var barraPlaneta;
var tempoCriaBomba // recebe ointervalo de criação da bomba
var indexExplosao, indexSom //Serve para criação de ids do jogo
var telaMsg;
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
                criaExplosao(2,bombasTotal[i].offsetLeft,null)
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
                criaExplosao(1,bombasTotal[i].offsetLeft -25 ,bombasTotal[i].offsetTop)
                bombasTotal[i].remove();
                tiro.remove();
            }
        }
    }
}
function criaExplosao(tipo,posX,posY) //tipo = 1 ar e 2 = Terra
{
    //Verificar se o gif ja ocorreu e remover elementos
    if(document.getElementById("explosao"+(indexExplosao-5)))
    {
        document.getElementById("explosao"+(indexExplosao-5)).remove();
    }
    let explosao = document.createElement("div");
    let img = document.createElement("img");
    let som = document.createElement("audio");
    //Atributos para divs
    let explosaoAtributosUm = document.createAttribute("class");
    let explosaoAtributosDois = document.createAttribute("style");
    let explosaoAtributosTres = document.createAttribute("id");
    //Atributos para imagens
    let imgAtributosUm = document.createAttribute("src");
    //Atributos para audio
    let somAtributosUm = document.createAttribute("src");
    let somAtributosDois = document.createAttribute("id");
    //Definido id da div
    explosaoAtributosTres.value = "explosao" + indexExplosao; //Definindo id diferentes para qualquer explosao

    if(tipo == 1)
    {
        explosaoAtributosUm.value = "explosaoAr"
        explosaoAtributosDois.value = "top:"+ posY + "px;left:" + posX + "px;";
        imgAtributosUm.value = "imgs/explosao_ar.gif?"+new Date();
    }
    else
    {
        explosaoAtributosUm.value = "explosaoChao"
        explosaoAtributosDois.value = "top:"+ (tamTelaHeight - 57) + "px;left:" + (posX - 17) + "px;";
        //Usamos new date para chamar um gif por explosao dando nome diferente
        imgAtributosUm.value = "imgs/explosao_chao.gif?" + new Date()
    }
    //definindo atributos do som
    //usando o mesma situação das imagens para o audio
    somAtributosUm.value = "audio/exp1.mp3?" + new Date()
    somAtributosDois.value = "som"+ indexSom;
    //Adicionado atributos nas divs
    explosao.setAttributeNode(explosaoAtributosUm)
    explosao.setAttributeNode(explosaoAtributosDois)
    explosao.setAttributeNode(explosaoAtributosTres)
    img.setAttributeNode(imgAtributosUm)
    som.setAttributeNode(somAtributosUm);
    som.setAttributeNode(somAtributosDois);
    //inserindo elementos no jogo
    explosao.appendChild(img);
    explosao.appendChild(som);
    document.body.appendChild(explosao);
    document.getElementById("som" + indexSom).play();

    indexExplosao++;
    indexSom++;
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
function gerenciaGame()
{
    barraPlaneta.style.width = vidaPlaneta + "px";
    if (contBombas <= 0)
    {
        jogo = false;
        clearInterval(tempoCriaBomba);
        telaMsg.style.backgroundImage = "url('imgs/vitoria.jpg')";
        telaMsg.style.display = "block";
    }
    if (vidaPlaneta <= 0)
    {
        jogo = false;
        clearInterval(tempoCriaBomba);
        telaMsg.style.backgroundImage = "url('imgs/derrota.jpg')";
        telaMsg.style.display = "block";
    }
    
}
function gameLoop()
{
    if(jogo)
    {
        //Funções de controle do jogo 
        controlaJogador();
        controleTiros();
        controlaBomba()
        gerenciaGame()
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
    barraPlaneta = document.getElementById("barraPlaneta");
    barraPlaneta.style.width = vidaPlaneta + "px";

    //Controles de Explosao
    indexExplosao = indexSom = 0;
    
    //inicialização de variaveis de tela de vitoria , derrota e inicio
    telaMsg = document.getElementById("telaMsg");

    //Game Loop do Jogo;
    gameLoop()
}
window.addEventListener("load",inicia)
document.addEventListener("keydown",teclaDown);
document.addEventListener("keyup",teclaUp);

