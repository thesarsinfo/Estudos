
const notas = [100,60,45,78,80,32,86];

const jogador =
[
    nome ="Thiago",
    pontos=1000,
    vidas=7
]
console.log(...jogador);

console.log(notas);
console.log(...notas); //Não podemos iterar então é util para concatenar elementos

function soma(n1,n2,n3)
{
    return n1 + n2 + n3
}
console.log(soma(...notas)) //vai ser usado os 3 primerios elementos do array 
