//Aula 16 AUla de indeof , concat 
/* 
Index of pesquisa o indice do elementos;
sort ordenação de elementos
reverse inverte a ordem dos elementos
concat concatena um Array A com Array B e forma Array C


*/

//let  = ["faca", "Perdeineira", "Corda" , "Lanterna" , "Luvas" , "Chaves", "Arame" ;
let mochila = [],mochila1 = [], mochila2 = [];
let num = [5,8,4,9,7,6,3,0,2,1];

num.sort(); // ordenar em ordem alfabetica mas geralmente usa-se função
num.reverse();

numerosString = num.join(); // Pega todos elementos de num e transfoma em string.

document.write(numerosString);
document.write(num[0] + "<br>");
document.write(num[1] + "<br>");
document.write(num[2] + "<br>");
document.write(num[3]+ "<br>");
document.write(num[4]+ "<br>");
document.write(num[5]+ "<br>");
document.write(num[6]+ "<br>");
document.write(num[7]+ "<br>");
document.write(num[8]+ "<br>");
document.write(num[9]+ "<br>");

document.write("Parte 3 /////////////////////////////// <br>")

mochila1.push("faca");           //0
mochila1.push("Perdeineira");    //1
mochila1.push("Corda");          //2
mochila1.push("Lanterna");       //3
mochila1.push("Luvas");          //4
mochila1.push("Chaves");  

mochila2.push("Arame");           //0
mochila2.push("Joelheiras");    //1
mochila2.push("Meias");          //2
mochila2.push("Moeda");       //3
mochila2.push("Pedra");          //4
mochila2.push("Canivete");  

mochila = mochila1.concat(mochila2);


document.write(mochila[0] + "<br>");
document.write(mochila[1] + "<br>");
document.write(mochila[2] + "<br>");
document.write(mochila[3] + "<br>");
document.write(mochila[4] + "<br>");
document.write(mochila[5] + "<br>");
document.write(mochila[6] + "<br>");
document.write(mochila[7] + "<br>");
document.write(mochila[8] + "<br>");
document.write(mochila[9] + "<br>");
document.write(mochila[10] + "<br>");
document.write(mochila[11] + "<br>");

document.write("Tamanho de itens da mochila 1: " + mochila1.length + "<br>" );
document.write("Tamanho de itens da mochila 2: " + mochila2.length + "<br>" );
document.write("Tamanho de itens da mochila : " + mochila.length + "<br>" );
// Parte 1
document.write("Parte 1 /////////////////////");
mochila.push("faca");           //0
mochila.push("Perdeineira");    //1
mochila.push("Corda");          //2
mochila.push("Lanterna");       //3
mochila.push("Luvas");          //4
mochila.unshift("Chaves");      //5      Adiciona no primeiro indice

document.write(mochila.indexOf("Lanterna") + "<br>");
 let teste = mochila.indexOf("Luvas");
 alert(teste);
 if (teste < 0)
 {
     alert("Item não encontrado");
 } else
 {
     alert("item encontrado");
 }


