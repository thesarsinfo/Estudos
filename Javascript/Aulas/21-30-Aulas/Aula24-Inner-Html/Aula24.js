//Aula 24
/*
modificar proproedades da tag
*/
let text = document.getElementById("cxtexto");
alert(text.value);
//Toda vez que der reload o campo do imput vai receber a string
text.value = "Curso de estudos";
// A tag p não trabalha com value e por isso usamo innerHTML
let txtp = document.getElementById("texto");
alert(txtp.innerHTML);
//Atribuindo novo valor no p innerHtml
txtp.innerHTML = "Nova string";

//Mundando elemento da div

let dive = document.getElementById("dv");
dive.innerHTML = "Vazio";