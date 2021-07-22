inicia = () =>
{
    //Mostra o elemento pai
    let elemento = document.getElementsByTagName("p");
    //Mostrando o elemento pai
    console.log(elemento[1].parentNode.nodeName);
    alert(elemento[1].parentNode.nodeName);
    //Metodo remove para remover o elemento
    elemento[0].remove();
    //usando o metodo removeChild
    let elementos = document.getElementById("cfbcursos").childNodes;
    let removeFilho = document.getElementById("cfbcursos")
    removeFilho.removeChild(elementos[15]);//sempre carrega a tag e seu conteudo

}
window.addEventListener("load",inicia);