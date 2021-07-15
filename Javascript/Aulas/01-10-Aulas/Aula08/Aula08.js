//Aula 08 Operadores logicos && e ||
//Tabela verdade;
/*
&& OPERADOR uma condição falsa sempre retornara falso
V   V   = V
V   F   = F
F   V   = F
F   F   = F
|| OR OPERADOR uma condição verdadeira retornara verdadeira
F   F   = F
V   F   = V
F   V   = V
V   V   = V

*/


let pontos = parseInt( prompt("Digite a pontuaçao do jogador","Digite aqui"));
pontos = 25;
let energia = 55
if (//  V               V
    (pontos >= 20 &&  pontos <= 30) // V

    ||                                  // V
    //      F           V 
    (pontos >= 50 && pontos <= 60 )// F
    )
{
    alert("Parabens campeao");
}else
{
    alert("Errou");
}
// Agora usando o operador && no meio da condição
if (//  V               V
    (pontos >= 20 &&  pontos <= 30) // V

    &&                                  // V
    //      V           V 
    (energia >= 50 && energia <= 60 )// V
    )
{
    alert("Parabens campeao");
}else
{
    alert("Errou");
}