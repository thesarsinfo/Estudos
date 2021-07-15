//Aula 18 Comando For
/* 
    for (contador inicializador; condição ; incrementos)
*/

let cont;
let num = [];
let mochila =
[
     ["Corda",1] ,
     ["Cura", 10] , 
     ["Lanterna",1] , 
     ["Pilhas", 20]
];
for (cont = 0; cont <10; cont++)
{
    console.log("Saraiva estudos!");
    num.push(cont);
    console.log(num[cont])
}
// for para matriz

for (let linha = 0; linha < 4; linha++)
{

    for(let coluna = 0; coluna < 2; coluna++)
    {
        console.log(mochila[linha][coluna] + " ");
    }
}