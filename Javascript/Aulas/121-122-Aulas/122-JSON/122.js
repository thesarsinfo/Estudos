
let colabJson =
'{'+
    '"colaboradores":'+
        '['+ 
            '{"nome":"Bruno","salario":10000,"idade":40},' +
            '{"nome":"Thiago","salario":13500,"idade":34},' +
            '{"nome":"Jumentino","salario":1100,"idade":55},' +
            '{"nome":"Clixtonoil","salario":2000,"idade":18},' +
            '{"nome":"Troufdas","salario":5000,"idade":21}' +
        ']' +
'}'
/**
 * metodo parse para converte um json para objeto literal
 * metodo stringfy converte um objeto literal para JSON
 */
let colabObj = JSON.parse(colabJson);
console.log(colabObj.colaboradores[0]);
for (let n of colabObj.colaboradores)
{
    console.log(n.nome);
    console.log(n.salario);
    console.log(n.idade);
}
console.log('-----------')
console.log(colabJson)
console.log('-----------')
let colabObjParaJson =
[
    {nome:"Bruno",salario:10000,idade:40},
    {nome:"Bruno",salario:10000,idade:40},
    {nome:"Jumentino",salario:1100,idade:55},
    {nome:"Clixtonoil",salario:2000,idade:18},
    {nome:"Troufdas",salario:5000,idade:21} 
]
let novoJson = JSON.stringify(colabObjParaJson);
console.log(novoJson)
            
           