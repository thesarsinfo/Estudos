let texto1  = document.getElementById("txt").innerHTML;
let texto2 = "texto1"
let res = texto1.indexOf("J"); //case sensitive e primeiro caractere encontrado
let res1 = texto1.lastIndexOf("C");
//Metodo Locatecompare onde 0 = igual e -1 =diferente
let res2 = texto1.localeCompare(texto2);
//Metodo Slice usa a posição inicial e final
let res3 = texto1.slice(22,32);
// Metodo Split
let res4 = texto1.split(" "); //Nesse caso cada palavra vira um vetor
//Metodo substr
let res5 = texto1.substr(4,6); //posição incial e tamanho do corte
//Metodo toLowerCase e toUpperCase
let res6 = texto1.toLowerCase();
let res7 = texto1.toUpperCase();
//Usando toUpperCase com substr
let res8 = texto1.toUpperCase().substr(22,10);


//Resultado
if(res < 0)
{
    document.write("Letra não encotrada");
}
else
{
    document.write(res + " : indexOf " + '<br>'); 
}
document.write(res1 + " : lastIndexOf " + '<br>'); 
if (res2 == 0)
{
    document.write("Strings iguais" + '<br>'); 
}
else
{
    document.write(res2 + " : LocateCompare em string diferentes" + '<br>'); 
}
document.write(res3 + " : Metodo Slice " + '<br>'); 
document.write(res4[1] + " : Metodo Split " + '<br>'); 
document.write(res5 + " : Metodo substr " + '<br>'); 
document.write(res6 + " : Metodo toLowerCase " + '<br>'); 
document.write(res7 + " : Metodo toUpperCase " + '<br>'); 
document.write(res8 + " : Metodo toUpperCase e substr " + '<br>'); 






