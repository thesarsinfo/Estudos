//Au14 - Parte 2 Push = Pop (adiciona e remove no ultimo indice) - Unshift e shift e o splice (No primeiro indice)

//let  = ["faca", "Perdeineira", "Corda" , "Lanterna" , "Luvas" , "Chaves", "Arame" ;
let mochila = [];

mochila.push("faca");           //0
mochila.push("Perdeineira");    //1
mochila.push("Corda");          //2
mochila.push("Lanterna");       //3
mochila.push("Luvas");          //4
mochila.unshift("Chaves");      //5      Adiciona no primeiro indice

mochila.pop(); // Remove o ultimo item do Array
mochila.shift() //Remove o primeiro indice do array
mochila.splice(2,1); //remove apartir do incide 2 e a quantidade de 1 elementos;

document.write(mochila[0] + "<br>");
document.write(mochila[1]+ "<br>");
document.write(mochila[2]+ "<br>");
document.write(mochila[3] + "<br>");
document.write(mochila[4] + "<br>");
document.write(mochila[5] + "<br>");