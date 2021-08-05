
let num = [5,2,8,15,30,4,25,37,19,9];

//filtro para elementos maiores que 10

maiorDez = num.filter( (ele) => 
    {
        return (ele > 10) && ele
        
    })
console.log(num)
console.log(maiorDez)

let dados =
[
    {id:15},
    {id:0},
    {id:-10},
    {id:null},
    {id:NaN},
    {id:'undefined'},
    {id:5.8},
    {id:15},
    {},
    {id:2}
]
console.log(dados)
let dadosValidos = dados.filter( (el) => 
    {
         return (typeof(el.id) == 'number' && !isNaN(el.id) && el.id > 0 ) && el
    })
console.log(dadosValidos)