//Coleção Map
//Criando um objeto map
let produtos = new Map();
//Setando valores manualmente em map
produtos.set("01","Mouse");
produtos.set("02","Teclado");
produtos.set("03","Monitor");
produtos.set("04","Gabinete").set("05","Nobreak") //na mesma linha fica confuso
//setando valores sem usar a palavra produtos, mas não pode ter o ponto e virgula
.set("06","lapela");
produtos.set("06","Memória") // vai sobreescrever;
//acessando valores do map
console.log("O tamanho do mapa é " + produtos.size); //tamanho do map
console.log(produtos.get("03")) //indicamos a chave e retorna Monitor
console.log(produtos.get("06")) //iria retorna lapela mas retornou memoria pq sobreescrevemos

console.log(produtos.get("07")) //retorna undefined

//Iniciando com valores iniciais
console.log("Produtos 2")
let produtosDois = new Map
([
    ["01","Mouse"],
    ["02","Teclado"],
    ["03","Monitor"],
    ["04","Gabinete"]
])

for (let p of produtosDois)
{
    //imprimindo as chaves
    console.log(p[0]);
    //imprimindo valores
    console.log(p[1])
}