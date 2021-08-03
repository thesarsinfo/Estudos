
const alo = function() // modo introdutorio
            {
                return "Alô mundo";
            }
console.log(alo());

const somaRest = (...num) => //modo usado em hoje em dia
{
    let res = 0
    
    for (let n of num)
    {
        res += n;
    }
    return res;
}

console.log(somaRest(1,2,3,4,5,6,7,8,9,10))
console.log(somaRest)

