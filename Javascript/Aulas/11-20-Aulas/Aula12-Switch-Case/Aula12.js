//Aula 12 - Switch case
//Testa uma variavel e executa uma serie de instruções
// Eu sei o valor de teste ou seja ambiente mais controlado
// O uso é parecido com csharp

let pos, res, pontos;
pontos = 100

if ( pontos >= 1000)
{
    pos = 1;
} else if (pontos >=900)
{
    pos = 2;
} else if (pontos >= 500)
{
    pos = 3
} else
{
    pos = 4
}

switch(pos)
{
    case 1:
        res = "Campeão <br> Medalha de Ouro"
    break;

    case 2:
        res = "Primeiro do ultimos  <br> Medalha de Prata"
    break;
    case 3:
        res = "Terceiro é melhor  <br> Medalha de Bronze"
    break;

    default:
        res = "Eliminado <br> Chora mais"
    break;
}

switch(pos)
{
    case 1:
    case 2:        
    case 3: 
        res += "<br>Subiu ao pódio";       
    break;
            
    default:
        res = "Eliminado <br> Chora mais"
    break;
}
document.write(res);