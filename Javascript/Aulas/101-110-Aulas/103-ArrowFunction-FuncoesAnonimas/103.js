
//Arrow function ou Função de seta
/*
(parametros) => { let expressao}
() => {let expressao1}
*/
//OBS so usamos chaves se houver mais linha de execução

const soma = (p1,p2) =>
{
    return p1 + p2;
}


const verificaPar = num =>
{
   return (num % 2 == 0) ? true : false    
}
console.log(verificaPar(soma(3,4)) ? "Numero Par" : "Numero Impar");