let painel
function inicia()
{
    painel = document.getElementById("painel");
    //Objeto screen pega infomações de resuluções da tela do usuario
    /*
    width, height, availWidth, availHeight
    */
    painel.innerHTML += " Resoluçao da TelaL " + screen.width + "px X " + screen.height + "px <hr>";
    painel.innerHTML += " Resoluçao da Tela disponivel " + screen.availWidth + "px X " + screen.availHeight + "px <hr>";
    painel.innerHTML += "Profundidade de cores (imagens)bits " + screen.colorDepth + " bits<hr>";
    painel.innerHTML += "Resolução cor da tela (pixel) " + screen.pixelDepth + "bits/pixel<hr>";
}

window.addEventListener("load",inicia);