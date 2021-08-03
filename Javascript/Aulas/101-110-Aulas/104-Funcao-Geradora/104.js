//função geradora sintaxe function* e colocar yield no seu valores
function* cores()
{
    yield 'Vermelho';
    yield 'Verde';
    yield 'Azul';
    yield 'Amarelo';
    yield 'Roxo';
    yield 'Preto';
    yield 'Branco';
}

for (let cor of cores())
{    
    console.log(cor);
}

const cor1 = cores();
console.log(cor1.next());
console.log(cor1.next());
console.log(cor1.next());
console.log(cor1.next());
console.log(cor1.next());
console.log(cor1.next());
console.log(cor1.next());

function* contar(numero)
{
    let contador = 0;
    while(contador < numero)
    {
         yield console.log(contador);
        contador++
    }
}

const conta = contar(10);
console.log(conta.next());
console.log(conta.next());
