// AUla 26 QuerySelectorAll tem diferença que podemos retorna tags que usa uma classe especifica ou tags diferentes
/*

*/

let ps = document.querySelectorAll("p");
document.write(ps[0].innerHTML + "<br>");
//nova cor
ps[0].style.color = "#00f";
//nova string
ps[0].innerHTML = "Novo Texto";
// pegando elementos da classe titulo do html
let elementos = document.querySelectorAll(".titulo");
for (let i = 0; i < elementos.length; i++)
{
    document.write(elementos[i].innerHTML + "<br><br>");    
}
//Retorna todos elementos p da classe titulo
let pTitulo = document.querySelectorAll("p.titulo")
document.write(pTitulo[0].innerHTML + "<br><br>");   
//elementos p dentro da tag div na cor verde
let pDiv = document.querySelectorAll("div > p");
for (let i = 0; i < pDiv.length; i++)
{
    pDiv[i].style.color = "#0a0";    
}
// Todos elementos  dentro da tag div na cor verde
let todosDiv = document.querySelectorAll("div > *");
for (let i = 0; i < pDiv.length; i++)
{
    todosDiv[i].style.color = "#0a0";    
}
// Todos elementos  dentro da tag div da classe quadro na cor verde
let todosDivQuadro = document.querySelectorAll("div.quadro > *");
for (let i = 0; i < todosDivQuadro.length; i++)
{
    todosDivQuadro[i].style.color = "#def";    
}
// Todos elementos  dentro da tag div da classe quadro de elemento p na cor verde
let todosDivQuadroPe = document.querySelectorAll("div.quadro > p");
for (let i = 0; i < todosDivQuadroPe.length; i++)
{
    todosDivQuadroPe[i].style.color = "#0a9";    
}
//Todos elementos p, H1, h3
let elementosPeH1H3 = document.querySelectorAll("p,h1,h3");
for (let i = 0; i < elementosPeH1H3.length; i++)
{
    elementosPeH1H3[i].style.color = "#f0f";   
} 
