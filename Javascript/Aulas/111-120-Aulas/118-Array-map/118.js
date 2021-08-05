
let num = [1,4,9,16,25];

raiz = num.map(Math.sqrt)
console.log(raiz);

const dobrar = (n) =>
{
    console.log(n * 2);
    return n * 2
}
let dobros = num.map(dobrar)
//OBS: No map é obrigatorio usar return e parametro de entrada
let triplos = num.map((num) =>
{
    let triplos = num * 3
    console.log('Número: ' + num + ' triplo: ' + triplos);
    return triplos
})
console.log(triplos)