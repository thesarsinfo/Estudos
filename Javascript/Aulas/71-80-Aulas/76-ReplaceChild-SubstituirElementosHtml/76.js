inicia = () =>
{
    let novoHUm = document.createElement("h1");
    let sub = 9; //variaavel para apontar um elemento em array
    let listaCursos = document.getElementById("cfbcursos");   
    let elementoAntigoP = listaCursos.childNodes[sub];
    let txtH = document.createTextNode(elementoAntigoP.innerHTML);
    novoHUm.appendChild(txtH);
    //ReplaceChild usa 2 parametros novo elemento e o antigo elemento para substituir
    listaCursos.replaceChild(novoHUm,elementoAntigoP);   
}
window.addEventListener("load",inicia);

