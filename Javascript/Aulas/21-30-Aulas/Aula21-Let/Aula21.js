//Aula 21 - Declaração let
/*
    var = escopo global = acesso ao todo programa
    let = escopo local = mas pode ser global se declaramos somente em cima ou fora de escopo de funçao ou if ou for
    
*/
var num = 10;
console.log(num); //num global


if(num == 10)
{
    let num = 5;
    console.log(num); //num de escopo // 5
}

console.log(num); // num global
