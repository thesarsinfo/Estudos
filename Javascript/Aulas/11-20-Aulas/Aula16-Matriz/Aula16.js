//AUla 16 - Matrizes ou array multidimencionais
/* 
    Prescisamos de 2 indices um para item e mochila
    mochila = []    item1   0   1
        0                  1       
      item nome   item quantidade
        0               1
    0  
    1
    2
    3
*/
let mochila = new Array();
let item1 = ["Corda ",2];
let item2 = ["Faca " , 1];
let item3 = ["Cura " , 5];
let item4 = ["Prego " , 35];
mochila.push(item1);
mochila.push(item2);
mochila.push(item3);
mochila.push(item4);
document.write("Item / Quantidade <br>");

document.write(mochila[0][0] + " - " + mochila[0][1] + "<br>");
document.write(mochila[1][0] +  " - " + mochila[1][1] + "<br>");
document.write(mochila[2][0] +  " - " + mochila[2][1] + "<br>");
document.write(mochila[3][0] + " - " + mochila[3][1] + "<br>");