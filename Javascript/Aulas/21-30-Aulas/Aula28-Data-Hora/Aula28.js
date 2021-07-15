//AUla 28 data e hora e sua manipulação

/*Obter dados GetDate e setar usamos setDate()
 + "<br>"
 let dt = new Date() */
document.write(Date() + "<br>");

let dt = new Date();
//                ano,mes,dia,hora,min,seg e milisegundos 
//e setando diretamente
let ndt = new Date(1978,02,07,10,20,50,29,2)
ndt.setDate(dt.getDate() + 2);
// Os metodos do setdate são iguais do getdate.

// settando diretamente


let dia = dt.getDate();
let diasem = dt.getDay()
let mes = dt.getMonth(); 
let ano = dt.getFullYear();

let horas = dt.getHours();
let minutos = dt.getMinutes();
let segundos = dt.getSeconds();

let meses = new Array
(
    "Janeiro", "Fevereiro","Março", "Abril", 
    "Maio", "Junho","Agosto","Setembro","Outubro","Novembro",
    "Dezembro"
);
let semanas = new Array
(
    "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta",
    "Sabado"
)

// vai retorna o indice do vetor o mes atual - 1 e
// O dia volta a data normal
document.write(dia + "<br>" );
document.write(diasem + "<br>" ); // Começa no domingo e retorna vetor

document.write(mes + "<br>" );
document.write(ano + "<br>" );

document.write( semanas[diasem] + " , " + dia + " de " + meses[mes]  + " , " + ano + "<br>");
document.write( horas + ":" + minutos + ":"  + segundos);

ndt.setDate(dt.getDate() + 4);



