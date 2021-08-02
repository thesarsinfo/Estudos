
sumirElemetos = (objeto) =>
{
    document.getElementById(objeto).hidden = true;
}
mostrarElementos = () =>
{
    pecorreElementos();
    objeto = event.target.dataset.nome
    document.getElementById(objeto).hidden = false;
}
rolar02 = () =>
{
    let objeto = event.target.dataset.nome;
    document.getElementById(objeto).scrollIntoView();
}
pecorreElementos = () =>
{
    for (let i = 1; i < 5; i++)
    {
        document.getElementById("c" + i).hidden = true;
    }
}

inicia = () =>
{
    pecorreElementos();
    document.getElementById("btnC1").addEventListener("click", mostrarElementos);
    document.getElementById("btnC2").addEventListener("click", mostrarElementos);
    document.getElementById("btnC3").addEventListener("click", mostrarElementos);
    document.getElementById("btnC4").addEventListener("click", mostrarElementos);

  
    //usando diretamente o hidden modo easy
    /*
    document.getElementById("btnC4").hidden = true; //false é padrão
    */
}
window.addEventListener("load",inicia)