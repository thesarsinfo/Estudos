
var minhaJanela;
var novaJanela;

function abreJanela()
{
    // posso abrir arquivos e podemos definir parametro de target ou iframe

    minhaJanela = window.open("tmp.html", "cfb");// padrão é _blank
    //espicificar janelas em seu tamanhos e posiçõe diferentes do padrão
    novaJanela = window.open("tmp.html","_blank", "width=300,height=300,top=200,left=200" )
}
function fechaJanela()
{
    minhaJanela.close();
    novaJanela.close();
}