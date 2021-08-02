

rolar02 = () =>
{
    let objeto = event.target.dataset.nome;
    document.getElementById(objeto).scrollIntoView();
}

rolar01 = () => //modo usando botao
{
    let objeto = document.getElementById("c2").scrollIntoView();
}
inicia = () =>
{
    document.getElementById("btnC1").addEventListener("click", rolar02);
    document.getElementById("btnC2").addEventListener("click", rolar02);
    document.getElementById("btnC3").addEventListener("click", rolar02);
    document.getElementById("btnC4").addEventListener("click", rolar02);
}
window.addEventListener("load",inicia)