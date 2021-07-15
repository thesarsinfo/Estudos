function trocaCarro(c)
{
   let objeto = document.getElementById("carro");
   if ( c == 1)
   {
       objeto.setAttribute("class","c1");
   }
   else if ( c == 2)
   {
       objeto.setAttribute("class","c2");
   }
   else if ( c == 3)
   {
       objeto.setAttribute("class","c3");
   }
}
function removerCarro(c)
{
   let objeto = document.getElementById("carro");
   objeto.removeAttribute("class"); 
}
function verificaCarro()
{
   let objeto = document.getElementById("carro");
    if (objeto.hasAttribute("class"))
    {
        alert("A div foi carregada corretamente com o atributo class");
    }
    else
    {
        alert("sem atributo class");
    }
}
