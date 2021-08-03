
const soma = (n1,n2) =>
{
    let res = n1 + n2
    return res;
}

console.log(soma(1,2))
const somaRest = (...num) =>
{
    let res = 0
    
    for (let n of num)
    {
        res += n;
    }
    return res;
}

console.log(somaRest(1,2,3,4,5,6,7,8,9,10))