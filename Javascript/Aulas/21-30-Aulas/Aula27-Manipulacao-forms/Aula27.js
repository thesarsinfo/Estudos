/*
 Aula 27
 Formularios trabalham com o objeto documents
 seus retorno são coleções e entao vamos trabalhar com vetores e arrays
*/

let fm = document.forms.length;
document.write(fm + "<br> <hr> <br>");// retorna 1 que é o numero de tags form dentro do documento que esta o script 
//se estiver 10 forms retorna 10

//1-) retornonado elementos
fm =  document.forms[0].id;
document.write(fm + "<br> <hr> <br>");
// 2- ) retorna o conteudo do id do elemento
fm =  document.forms.item(0).id;
document.write(fm + "<br> <hr> <br>");
fm =  document.forms.namedItem("curso1").id;
document.write(fm + "<br> <hr> <br>");
//3 -/ Retornando o proprio formularios e escrevendo
fm = document.forms.namedItem("curso2").innerHTML; // funciona usamo qualquer elemento usaodos acimas
document.write(fm + "<br> <hr> <br>");
// 4 -) Pegar valores do elementos dentro do formulario // Lembrando que o form ou label não conta como indice ou seja
// o input vai o elemento 0
fm = document.forms["curso1"].elements[0].value;
document.write(fm + "<br> <hr> <br>");
fm = document.forms["curso1"].elements[1].value;
document.write(fm + "<br> <hr> <br>");
// 5 - ) Modo mas ok de trabalhar
let f1 = document.forms[0];
document.write(fm + "<br> <hr> <br>"); //Objeto Elementoshtml

let elemento = f1.elements;
document.write(elemento.length);
elemento[0].style.backgroundColor = "#ddd";

// 6 Usanod for para carregar elementos

for (let i = 0; i < elemento.length; i++)
{
    elemento[i].style.backgroundColor = "#ddd";    
}

// 7 Usando o get element by id
//Aqui vai pegar o primeiro 1 pq o valor inicial foi setado no html

document.write(document.getElementById("curso1").elements[0].value);


