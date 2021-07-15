let num = 10;
// Operações de incremento
console.log("Operações de incremento");
num = num + 1;
console.log(num);
num += 1;
console.log(num);
num++
console.log(num);

//Operações de decremento
num -= 1;
console.log(num);
num = num - 1;
console.log(num);
num--
console.log(num);

//Operações de multiplicação
num = num * 2;
console.log(num);
num *= 2;
console.log(num);

//operaçõs de divisao
num = num / 2;
console.log(num);
num /= 2;

//Operações de pre incremento
let num2 = 12;
console.log(num2++); //deveria imprimir 13 
console.log("Deveria imprimir 13 mais imprimiu 12");
// por isso usamos ++pre incremento
num2 = 12;
console.log("Usando o pre incremnto");
console.log(++num2); 

//Operação de inversão de numero positivo para negativo
//forma tradicional
let num3 = 10;
num3 *= -1;
console.log("O valor de num : " + num3);
//forma de modo de inversao temporaria
num3 = 10;
console.log(-num3);
console.log("O valor de num3 no estado original " + num3);