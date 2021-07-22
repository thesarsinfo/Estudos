inicia = () =>
{
    document.getElementById("btnAdd").addEventListener("click",() => {listaElementos()})
    document.getElementById("contar").addEventListener("click",() => {contar()})

}
listaElementos = () =>
{
    let lista = document.getElementById("listaElementos");
    let texto = document.getElementById("fNome");
    let li = document.createElement("li");
    li.textContent = texto.value;
    //Insert before trabalha com 2 parametro (Elemento adicionar, 
    //Qual elemento antes adicionar)
    //childnodes recebe o vetor e se colocamos um valor no array ele vai se inserindo
    //antes desse vetor
    lista.insertBefore(li,lista.childNodes[2]).style.listStyleType = "none";
    console.log(lista.childNodes[1]);
    texto.value = "";
    texto.focus(); 
}
contar = () =>
{
    let lista = document.getElementById("listaElementos");
    let num = lista.childNodes.length;
    alert("Numero de elementos da lista " + num)

}
window.addEventListener("load",inicia);