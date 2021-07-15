/*
Vamos fazer um pre carregamento da pagina para evitar lag ou mal funcioanmentos
*/
let imgs=[]
let slider;
let imgAtual;
let maxImg;
let tmp;
let tempoTroca
let vTempo;
let vbarra;

function preCarregamento()
{
    let s = 1; // recebe o numero da imagem no nome da imagem
    for (let i = 0; i < 5; i++)
    {        
        imgs[i]= new Image();
        imgs[i].src = "imgs/s"+s+".jpg";
        s++;
        
    }
}
//Carrega a imagem na div

function carregarImg(img)
{
    slider.style.backgroundImage = "url('" + imgs[img].src + "')";
}
// inicia o pre carregamento
function inicia()
{
    preCarregamento()
    imgAtual = 0;
    maxImg = imgs.length -1;
    vbarra = document.getElementById("dvbarra")
    slider = document.getElementById("dvslider");
    carregarImg(imgAtual);
    tempoTroca = 0 ;
    anima();
    
}
function trocaImagem(dir)
{
    tempoTroca = 0;
    imgAtual += dir;
    
    if(imgAtual > maxImg)
    {
        imgAtual = 0;
    }
    else if(imgAtual < 0)
    {
        imgAtual = maxImg;
    }
    

    carregarImg(imgAtual)
}
function anima()
{
    tempoTroca++;
    if(tempoTroca >= 500)
    {
        tempoTroca = 0;
        trocaImagem(1);
    }
    vTempo = tempoTroca / 5;
    vbarra.style.width = vTempo + "%";
    window.requestAnimationFrame(anima);
}
window.addEventListener("load", inicia);