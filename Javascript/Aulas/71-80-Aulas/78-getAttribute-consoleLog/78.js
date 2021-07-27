inicia = () =>
{
    elementosP = document.getElementsByTagName("p")    
    let atributosObtidos = elementosP[1]
    let atributos = atributosObtidos.getAttribute("class");
    console.log(atributos);
}
window.addEventListener("load",inicia);