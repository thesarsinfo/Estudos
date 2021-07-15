/*
Aula 30 - Declaração de funções no javascript
Criamos para melhor controle e organização do codigo atraves
de sua chamada.
function nome_da_função (entrada de parametros) {code}
chamada da função
paramentos são dados enviados para função.
nome_da_função();
*/ 
function escreve()
{
    document.write("Saraiva Estudos a todo vapor <br>");   
}
function soma( n1 , n2)
{
    let res = n1 + n2;
    document.write(res + "<br>");
}
function soma(n3,n4)
{
    let res = n3 + n4;
    return res;
}
let numeros = new Array(10,2,5,30,25,19,20,50);
function media(nums)
{
    let tam = nums.length;
    let soma = 0;
    for (let i = 0; i < tam; i++) 
    {
        soma += nums[i];        
    }
    return Math.round(soma / tam);
}
escreve();
soma(5,2); //passagem de parametros
document.write(soma(8,4) + "<br>");
res = soma(8,5);
document.write(res + "<br>");
let teste = media(numeros);
document.write(teste)

