var num = 10;
var num = 100;

console.log(num)

let num1 = 20;
//escopo diferentes o let temos que tomar cuidado 
{
    let num1 = 200;
    console.log(num1)
} 
console.log(num1);

//const é uma variavel imutavel

const teste = 1021;
/*
teste = 10;  */ 
console.log(teste)

// Funções anonimas são uteis usando a constante

const dobro = (numeroDobrar) =>
{
    return numeroDobrar * 2;
}
console.log(dobro(8));