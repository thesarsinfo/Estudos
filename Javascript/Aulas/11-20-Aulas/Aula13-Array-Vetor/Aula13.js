//Aula 13 Array - vetor
/*
    Todo vetor começa com elemento 0
*/
let cor, cor1, cor2, cor3;
//cor = new Array();
cor = [];
cor1 = "Preto";
cor2 = "Branco";
cor3 = "Vermelho";
// Metodo de adicionado elementos no vetor
cor.push(cor1);
cor.push(cor2);
cor.push(cor3);
cor.push("Verde");
cor.push("Azul");
cor[5] = "Roxo"

document.write(cor[5] + "<br><br>" );
console.log(cor[0])

let itens = ["faca", "Perdeineira", "Corda" , "Lanterna" , "Luvas" , "Chaves", "Arame" ];
let mochila = [];

mochila.push(5);
mochila.push(0);
mochila.push(3)

document.write(itens[mochila[0]] + "<br>");
document.write(itens[mochila[1]] + "<br>");
document.write(itens[mochila[2]] + "<br>");
