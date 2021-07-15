//
/* 
Bloco try recebe a rotina que queremos ser analizada um provavel erro;
traz um feedback melhor ao usuario;
Quando gera o erro ele passa para o bloco cacth
Catch tramento de erro.
Finally bloco nao obrigatorio que é executado mesmo com erro ou nao
*/
var num; //Maximo 10
try {
    console.log("bem vindo \n");
    num = 20;
    if (num > 10)
    {
        throw new Error("Valor Invalido");
    }
    console.log("Volor: " + num);
    console.log("Saraivas estudo");
} catch (err) 
{
    console.log("Mensagem de erro: " + err.message);
    num = 10;
    
} finally
{
    console.log("O valor maximo é de : " + num);
    console.log("Fim de programa");
}