
const aluno = {nome:"Thiago",sobrenome:"Saraiva"};
const notas = {nota1: 80, nota2: 75,nota3:92, nota4:85}
const info = {...aluno,...notas};

for(let dado in aluno)
{
    console.log("Inicio linha")
    console.log(dado); //imprime a propriedade
    //imprimir o valor
    console.log("------")
    console.log(aluno[dado]) //imprime o valor da propriedade
    console.log("Proxima linha")
}
console.log("------")
console.log("------")
console.log("------")
console.log("Inicio do segundo for")
console.log("------")
console.log("------")
console.log("------")

for(let dado in info)
{
    console.log("Inicio linha")
    console.log(dado); //imprime a propriedade
    //imprimir o valor
    console.log("------")
    console.log(info[dado]) //imprime o valor da propriedade
    console.log("Proxima linha")
}
//for of

let notas2 = [100,80,75,30,64,47,98,81,60]
let aprovados = 0;
let reprovados = 0
for (let n of notas2)
{
    n >= 60 ? aprovados++ : reprovados++;
}
console.log( "Aprovados: " + aprovados + " reprovados " + reprovados);