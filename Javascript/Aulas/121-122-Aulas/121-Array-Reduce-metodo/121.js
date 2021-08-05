
let num = [0,1,2,3,4,5]
let soma = num.reduce( (n1,n2) => 
{
    console.log('n1: ' + n1 + ' + n2: ' + n2 + ' = ' + (n1 +n2))
    
    return n1 + n2

    /* Primeira inteiração = 0 + 1 {index 1} = ((1))
        segunga iteração = ((1)) + 2 {index 2}  = ((3))
        terceira iteração = ((3)) + 3 {index 3} = ((6))
        Quarta iteraçao = 6 + 4 {index 4}  = 10
        Ultima iteração = 10 + 5 {index 5} = 15
     * 
     */
})
console.log(soma)

let pessoas =
[
    {nome:'Bruno',idade:40},
    {nome:'Scarlindo',idade:30},
    {nome:'Fastiga',idade:25},
    {nome:'Glebnaro',idade:50},
    {nome:'Ogilda',idade:18},
]

let nomes = pessoas.reduce( (pe1,pe2)=>
{
    //adicionando um array para pessoa 1 somente o nome dela
    pe1.push(pe2.nome)
    return pe1
},[]/*convertendo objeto literal para array*/ )
console.log(...nomes)