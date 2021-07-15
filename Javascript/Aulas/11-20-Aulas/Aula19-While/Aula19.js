//Aula 19 While

let num;
let num2;
// existe 3 formas de escrever
num = 0
while (num < 10)
{
    console.log(++num);//pouco usual
}
num = 0
while (num++ < 10)// tambem pouco usual
{
    console.log(num);
}
num = 0
while (num < 10) // forma mais comum
{
    console.log(num);
    num++;
}
num = true;
cont = 0;
while (num ) // forma mais comum
{
    console.log(cont);
    cont++;
    if (cont > 10)
    {
        num = false;
    }
}