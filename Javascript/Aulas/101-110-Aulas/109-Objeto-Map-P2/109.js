let produtosDois = new Map
//Podemos colocar elementos mais complexos dentro dos valores como array
([
    ["01",["Mouse","R$180,00","6 Botões"]],
    ["02",["Teclado","R$35,90","128 Botões"]],
    ["03",["Monitor","R$652,00","4 Botões"]],
    ["04",["Gabinete","R$150,00","3 Botões"]]
])

console.log("Tamanho: " + produtosDois.size);

let iteKey = produtosDois.keys() // armazena como um iterator de chave
let iteValor = produtosDois.values() // armazena como um iterator de valores


//percorrer o elemento e executar uma função nele
//usamos o metodo foreach onde indicamos o map e a função
info = (valor , chave) =>
{
    //ambos as formas funciona do mesmo jeito
    console.log("Chave: " + chave + " - Valor: " + valor)
    
    console.log("Chave: " + iteKey.next().value  + " - Valor: " + valor)
    console.log("Chave: " + iteKey.next().value  + " - Valor: " + iteValor.next().value)

}
produtosDois.forEach(info)

//Procurando elementos dentro do mapa retornado true ou false sempre procure pela CHAVE
console.log(produtosDois.has("02") ? "Produto Encontrado" :"Produto inexistente");



//deletando elemento
produtosDois.delete("03");
//Esvaziando todos os elementos

//produtosDois.clear()
/*
for (let p of produtosDois)
{
    //imprimindo as chaves
    console.log(p[0]);
    //imprimindo valores
   
    console.log(...p[1]);
    //decobrindo o tipo de array usando typeof
    console.log(typeof(p[1]));

    //imprimindo valores em reais
    console.log(p[1][1])
    
}
*/