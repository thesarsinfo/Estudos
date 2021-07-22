destaque = () =>
{ 
    let num = document.getElementById("fNum").value
    let elementosPs = document.getElementsByTagName("p");
    for (let i = 0; i < elementosPs.length; i++)
    {       
            elementosPs[i].removeAttribute('style'); //removendo atributo       
    }
    let atributo = document.createAttribute("style");
    atributo.value="color:#f00; font-size:35px;";
    elementosPs[num].setAttributeNode(atributo);
}

inicia = () =>
{
    document.getElementById("btnDestaque").addEventListener("click",() =>{destaque()})
    
}
window.addEventListener("load",inicia);