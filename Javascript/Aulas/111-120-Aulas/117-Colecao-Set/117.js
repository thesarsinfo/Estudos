
let meuSet = new Set([1,2,3,3,2]); //Não vai inserir os valores duplicados;
// adicionando elementos
meuSet.add(4);
meuSet.add(5);
meuSet.add(6);
console.log(meuSet)
console.log(meuSet.size);
console.log('---------------');
//temos metodos delete, clear e entries
for(n of meuSet)
{
    console.log(n); //Não vai inserir os valores duplicados;
}