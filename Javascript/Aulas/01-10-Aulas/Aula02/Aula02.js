//Uso de variaveis temos 3 tipos de variaveis let, const e var sendo var para global,
// java script é de tipagem fraca;
let canal = "Saraiva estudos";
let ano = 2021;
let num = 10;

document.write(canal);
document.write("<br>");
document.write(num);
document.write("<br>");
//O comandos acima é a mesma coida que
document.write(canal + "<br>" + num); //concatenação
//Não começar as variaveis com numero ou usar caracter especial
//modo implicito
curso = "javascript"
document.write(canal + "<br>" + num + "<br>" + curso + "<br>");
//contacatenação de tipos de valores diferentes
let texto = canal + "<br>" + num; 
document.write(texto);
let br = "<br>";
document.write("Parte 3" + br)
//fazendo contatenação entre numeros e string e somando numeros
texto = canal + br + num + br + (ano + num) + br
document.write(texto);