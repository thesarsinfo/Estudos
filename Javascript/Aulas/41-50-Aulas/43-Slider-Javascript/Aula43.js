/*
Vamos fazer um pre carregamento da pagina para evitar lag ou mal funcioanmentos
*/
let imgs=[]
let slider;
let imgAtual;
let maxImg;
let tmp;
let tempoTroca
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
    slider = document.getElementById("dvslider");
    carregarImg(imgAtual)
    tempoTroca = 3000 // 3 seg
    tmp = setInterval(trocaImagem,tempoTroca);
}
function trocaImagem()
{
    imgAtual++;
    
    if(imgAtual > maxImg)
    {
        imgAtual = 0;
    }
    

    carregarImg(imgAtual)
}
window.addEventListener("load", inicia);