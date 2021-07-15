/* 
Aula 29 Classe math metodos e constantes
seno
conseno
sqrt ...

*/
let valor = -10;
let pi = Math.PI
document.write(pi + "<br>");
let eu  = Math.E;
document.write(eu + "<br>");
eu  = Math.SQRT1_2;
document.write(eu + "<br>");
//valor absolute
eu  = Math.abs(valor);
document.write(eu + "<br>");
//Arredondamento para cima com ceil
valor = 10.3;
eu  = Math.ceil(valor);
document.write(eu + "<br>");
//Arredondamento para baixo com floor
valor = 10.3;
eu  = Math.floor(valor);
document.write(eu + "<br><hr>");
//Arredondamento para depende da casa decimal com round
valor = 10.5; // arrendoda para cima
eu  = Math.round(valor);
document.write(eu + "<br><hr>");
//Elevaçoa de numero.
valor = 10; // arrendoda para cima
eu  = Math.pow(valor, 2); //100
document.write(eu + "<br><hr>");
//Elevaçoa de numero.
valor = 10; 
eu  = Math.pow(valor, 2); //100 o 2 é o tipo de potencia
document.write(eu + "<br><hr>");
//Raiz do numero.
valor = 10; 
eu  = Math.sqrt(valor); 
document.write(eu + "<br><hr>");
//Metodo random para valor aleatorio
valor = 10; 
eu  = Math.random() * 10; //um valor aletorio até o limite
document.write(eu + "<br><hr>");
//Numero aleatorio da mega sena.
valor = 59;
let teste = [6];
for (let i = 0; i < 6; i++) 
{

    document.write(Math.round(Math.random() * valor)+ 1 +" ");
     teste.push(Math.round(Math.random() * valor)+ 1)
}
document.write("<br><hr>");
//Cosseno do angulo
let angulo = 90 //valor em graus
let c = Math.cos(angulo * Math.PI / 180); //devemos fazer a tranformação de graus para radianos
document.write(c + "<br><hr>"); // 0 no bug do 6
//seno do angulo
angulo = 90
c = Math.sin(angulo * Math.PI / 180);
document.write(c + "<br><hr>"); // 1
document.write(Math.max(teste) + "<br><hr>");
document.write(Math.min(teste)+ "<br><hr>");

