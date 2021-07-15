let texto1  = document.getElementById("txt").innerHTML;
let texto2 = "      CFB Cursos - Curso de Javascript      ";
let texto3 = "CFB\n Cursos - \"Curso\" de Javascript " 
//Uso de caractere especiais \\Curso\\
let num = 15
//Metodo toString
let res = num.toString(); //base 10
let bin = num.toString(2); //base 2
let oct = num.toString(8); // base 8
let hex = num.toString(16); //base 16
//metodo trim elimina espaços iniciais e finais no texto e não elimina os 
//espaços intermediarios para isso use o split(" ");
let res1 = texto2.trim();




//Resultados
document.write(res + " : Metodo toString() " + '<br>'); 
document.write(bin + " : Metodo toString() base binaria " + '<br>'); 
document.write(oct + " : Metodo toString() base octal" + '<br>'); 
document.write(hex + " : Metodo toString() base hexadecimal" + '<br>'); 
alert(res1 + " Metodo trim");
document.write(texto3 + " : caractere especial " + '<br>'); 
alert(texto3);// para pular linha o <br> não funciona

