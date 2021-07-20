let largura, larguraTotal, altura, alturaTotal , posicaoX, posicaoY;
let painel


function infomacoes()
{
    largura = window.innerWidth; 
    larguraTotal = window.outerWidth
    altura = window.innerHeight;
    alturaTotal = window.outerHeight;
    posicaoX = window.screenX;     
    posicaoY = window.screenY;
    painel.innerHTML = "L:" + largura + " LT: " + larguraTotal + " Ai: " + altura
    + " At: " + alturaTotal + " PosX: " + posicaoX + " PosY " + posicaoY;
}

function inicia()
{
    btnTamanho = document.getElementById("btnTamanho");
    btnTamanho.addEventListener("click",infomacoes);
    painel = document.getElementById("painel") 
    
    
}

window.addEventListener("load",inicia)
