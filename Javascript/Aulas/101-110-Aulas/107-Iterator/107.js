let v
let num = [5,1,4,2,3];

let ite = num[Symbol.iterator]() //ite de iterador
let tam = num.length
console.log("O tamanho do array é " + tam)
//let valor1 = ite.next().value
for(let i = 0; i < num.length; i++)
{
    let v = ite.next().value;
    (v % 2 == 0) ? console.log("Par") : console.log("Impar");
}
/*
console.log(ite.next().value); //retorna o valor
console.log(ite.next().value); //retorna o valor
console.log(ite.next().value); //retorna o valor
console.log(ite.next().value); //retorna o valor
console.log(ite.next()); //retorna o objeto
console.log(ite.next().value); //retorna o underfined pq ja acabou a manipulação do array
console.log(valor1)
*/