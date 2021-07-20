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
function rolagem()
{
    window.scrollBy(1000,1000); //valores em pixel;
}

function inicia()
{
    btnTamanho = document.getElementById("btnTamanho");
    btnTamanho.addEventListener("click",infomacoes);
    btnRolar = document.getElementById("btnRolar");
    btnRolar.addEventListener("click",rolagem);
    painel = document.getElementById("painel");    

    //Pegndo a quantidades de iframes
    let qtde = window.length; // O lenght pega o numeros de iframes
    let qtPainel = document.getElementById("qtPainel").innerHTML = qtde;
    //Carregando frames do site mas seria mais interessante usar outro array com 
    //endereços ou imagens de propaganda
    for (let i = 1 ; i < qtde; i++)
    {
        window.frames[i].location = "http://www.cfbcursos.com.br"
    }
}

window.addEventListener("load",inicia)