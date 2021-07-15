// Aula 23 get element by Id
/*
Manipullar elementos de ID do html

*/
// Esse codigo abaixo nunca vai funcionar se o carregamento do script estiver no head ou encadeado acima do elemento
let txt = document.getElementById("texto").style
let cx = document.getElementById("caixa").style
txt.color = "#f00";
txt.fontSize = "50px";
cx.border = "1px solid #000";
cx.width = "300px";
cx.height = "300px";
cx.backgroundColor = "#aaa";