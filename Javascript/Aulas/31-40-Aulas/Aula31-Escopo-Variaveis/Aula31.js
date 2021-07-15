/* 
Aula 31 - Escopo da funções e visibilidade de variaveis
saber se uma variavel é visivel ou nao se esta no escopo local
ou global
*/
var nomeCor = "Vermelho"; // escopo ou caixa diferentes
var nomeCor; // recebe o valor inicializado com vermelho
//caixa raiz ^^
function cor() 
{
    //caixa função
    //document.write("Primeira impressao: " + nomeCor + "<br>");
    // se declaramos let nome cor ele terá escopo de fução
    // OD jeito abaixo voce esta usando a variavel acima que
    //esta no escopo global 
    let nomeCor = "Azul";
    //Obs Para usar o this a variavel deve esta declarado como var
    document.write("Primeira impressao com Variavel Global: " + this.nomeCor + " variavel local " + nomeCor + "<br>");    
}
document.write("terceira impressao: " + nomeCor + "<br>");   
cor();
document.write("Quarta impressao: " + nomeCor + "<br>");   
