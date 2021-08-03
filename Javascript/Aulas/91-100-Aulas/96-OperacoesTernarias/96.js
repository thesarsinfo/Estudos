/*
teste logica ? Se true : Se falso
*/

let n1 = 10;
let n2 = 5;
let op = true;

n1 == n2 ? 
(
    console.log("iguais")
)
:
(
    console.log("Diferentes"),
    console.log("quebom"),
    n1 = n1 + n2,
    console.log(n1)
);
//usando variaveis e condição and
//A condição abaixo é mesma coisa que um if sem o else
const r2 =  op && "If sem um else caso retorne verdadeiro";
console.log(r2);