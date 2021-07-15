let texto  = document.getElementById("txt").innerHTML;
let txt2 = "aula 47 do curso de javascript";
let txt3 = " - texto teste";
    //Metodo Search
    let res = texto.search(/curso/i); // Modificador g não funciona
    //Metodo Replace
    let res1 = texto.replace(/curso/ig,"aula"); //Trocando curso por aula
    //Metodo CharAt
    let res2 = texto.charAt(2); 
    //Metodo charCodeAt retorna o codigo da letra
    let res3 = texto.charCodeAt(2); 
    //Metodo fromCharCode informamos um codigo e retona a letra correspondente
    let res4 = 66
    //Metodo Concat
    let res5 = texto.concat(txt2 + txt3);

    document.write(res + " : " + '<br>'); // Resultado aparece na posição 
    //como fosse um array em numero
    // Resultado dp Replace
    document.write(res1 + " : " + '<br>'); //Trocou todos os curso para aula
    document.write(res2 + " : " + '<br>'); //Pega a letra da sentença
    document.write(res3 + " : " + '<br>'); //Pega o codigo da letra de pc
    document.write(String.fromCharCode(res4) + '<br>');
    document.write(res5 + '<br>')




