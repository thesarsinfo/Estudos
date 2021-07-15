function inicia()
{
    /*
        <p>Modificadores de Pesquisa</p>
        <p>i = sem case sensitive</p>
        <p>g = diz ao metodo para encotrar todas as ocorrencias da palavra cada
        ocorrencia fica em um array
        </p>
        <p>m = Pesquisa normal sem armazenar em array</p>
    */
    let texto  = document.getElementById("txt").innerHTML;
    //Pesquisa Simples
    let resultado = texto.match("de");
    //Pesquisa exata porem procurando de mais de 1 ocurrencia
    let resultado2 = texto.match(/de/g); //Usando modificado g
    //Pesquisa exata porem sem case sensitive
    let resultado3 = texto.match(/javascript/ig); //Usando modificado ig
    //Pesquisa de vogais
    let resultado4 = texto.match(/[aeiou]/ig)
    //Pesquisa tudo menos as vogais [o i]
    let resultado5 = texto.match(/[aeu ^oi]/ig)
    //Pesquisa em range
    let resultado6 = texto.match(/[a-g]/ig)
    //Pesquisa usando um separado para deixar o codigo mais legivel
    let resultado7 = texto.match(/[a|o|e]/ig)
    //Pesquida usando metacaracteres
    let resultado8 = texto.match(/\d/ig);
    let resultado9 = texto.match(/\w/ig);


    //Resulados
    document.write(resultado + " : " + resultado.length + '<br>');
    document.write(resultado2 + " : " + resultado2.length + '<br>');
    document.write(resultado3 + " : " + resultado3.length + '<br>');

    document.write(resultado3[0] + '<br>');
    document.write(resultado3[1] + '<br>');

    document.write(resultado4 + " : " + resultado4.length + '<br>');
    document.write(resultado5 + " : " + resultado5.length + '<br>');
    document.write(resultado6 + " : " + resultado6.length + '<br>');
    document.write(resultado7 + " : " + resultado7.length + '<br>');
    document.write("lista de metacaracteres:" + "<br>");
    document.write(resultado8 + " : " + resultado8.length + '<br>');
    document.write(resultado9 + " : " + resultado9.length + '<br>');


}
window.addEventListener("load",inicia)
