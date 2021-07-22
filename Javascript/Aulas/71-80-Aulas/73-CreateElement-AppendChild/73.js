inicia = () =>
{
    document.getElementById("btnAdd").addEventListener("click",() => {listaElementos()})
}
listaElementos = () =>
{
    let lista = document.getElementById("listaElementos");
    let texto = document.getElementById("fNovo");
    let li = document.createElement("li");
    li.textContent = texto.value;
    lista.appendChild(li);
    texto.value = "";
    texto.focus(); 
}
window.addEventListener("load",inicia);