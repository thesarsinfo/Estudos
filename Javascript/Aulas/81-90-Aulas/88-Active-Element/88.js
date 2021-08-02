var dvCaixa, frames

//Função menos elegante para uso inline no body não mostra imgs e p
ativo = () =>
{
    let elemento = document.activeElement.tagName;
    console.log(elemento);
}
function loop()
{
    //Podemos pegar id , class , tags 
    //NA aula fizemos de duas forma diferentes pegamos a tag e o elemento
    dvCaixa.innerHTML = document.activeElement.tagName
    dvCaixa.innerHTML = document.activeElement

    frames = requestAnimationFrame(loop);
}
function copiarTexto()
{
    /* resolução em varias linhas
    let caixa = document.getElementById("texto_selecionado");
    let elemento = document.activeElement;
    let selecao = elemento.value.substring(elemento.selectionStart,elemento.selectionEnd);
    caixa.innerHTML = selecao;
    */
   //resolvendo em 1 linha
   document.getElementById("texto_selecionado").innerHTML = document.activeElement.
        value.substring
        (document.activeElement.selectionStart ,document.activeElement.selectionEnd);
}
function inicia()
{
   // dvCaixa = document.getElementById("caixa");
   // 2 Forma
   // loop();
   //3 forma Selecionando texto e usando botao  
   let texto = document.getElementById("txt_original");
   texto.addEventListener("mouseup",copiarTexto)


}
window.addEventListener("load",inicia)