
//função sincrona contagem de 1 a 10

contar = (n) =>
{
    let cont = 0
    for(let i = 0; i < n; i++)
    {
        cont++
    }
    return cont
}
//função assincrona com resposta errada executa antes de terminar o processo
contarT = (n) =>
{
    let cont = 2
    let t = setTimeout(() => 
        {
            for(let i = 0; i < n; i++)
            {
                cont++
            }
        },2000 )
    
    return cont
}
function contarP(n)
{
    let cont = 0;
    let p = new Promise((resolve,rejected) =>
    {
        let t = setTimeout(() => 
        {
            for(let i = 0; i < n; i++)
            {
                cont++
            }
            //Quando sabemos que a função foi resolvida ate o final quando cont = n
            cont == n ? resolve(cont) : rejected("Erro na execuçao")
        },5000)
        
    })
    console.log(p)
    console.log(cont);
    return p;
}
function contarP2(n)
{
    let cont = 0;
    let p = new Promise((resolve,rejected) =>
    {
        let t = setTimeout(() => 
        {
            for(let i = 0; i < n; i++)
            {
                console.log(i + 1);
                cont++
            }
            //Quando sabemos que a função foi resolvida ate o final quando cont = n
            cont == n ? resolve(cont) : rejected("Erro na execuçao")
        },5000)
        
    })
    
    console.log(p)
    console.log(cont);
    return p
}

function somaPositivos(n1,n2)
{
    let p1 = new Promise
    (
    (res,rej) =>
        {
            n1 >= 0 && n2 >=0 ? res(n1 + n2) : rej('Erro na escolha de numeros')
        }
    )
    return p1
}



async function contarAsync(n)
{
    const r = await contarP(n) 
    const r1 = await contarP2(n + 10)    
    console.log(r,r1);
}
contarAsync(100)

//console.log(contar(10000));
//Essa de baixo so é executado quando a de cima estiver pronto
//console.log(contarT(10));//retorna 0 sem promisse
/*
contarP(100)
    .then(sucesso => console.log('Sucesso: ' + sucesso))
    .catch(erro => console.log('Erro da Promisse: ' + erro))
*/
/*
somaPositivos(null,20,5)
    .then(sucesso => console.log('Sucesso: ' + sucesso))
    .catch(erro => console.log('Erro da Promisse: ' + erro))
*/

    
