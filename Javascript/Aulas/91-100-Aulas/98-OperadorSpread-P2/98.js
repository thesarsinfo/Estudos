
const produtos = 
[
    {
        id:'001',
        desc:['Mouse','25.00']
    },
    {
        id:'002',
        desc:['Teclado','50.00']
    },
    {
        id:'003',
        desc:['Monitor','430.00']
    },
]
console.log(produtos);
//copiar elementos

const p = [...produtos];
console.log(p);

const  n1 = [100,200,300];
const  n2 = [400,500,600];
const  n3 = [700,800,900];
//Obs só funciona com objeto do mesmo tipo array com array ou objeto com objeto
const  n4 = [...n1,...n2,...n3];
console.log(...n4)

const aluno = {nome:"Thiago",sobrenome:"Saraiva"};
const notas = {nota1: 80, nota2: 75,nota3:92, nota4:85}
const info = {...aluno,...notas};
console.log(info);
notas.nota1 >= 50 ? console.log("aprovado") : console.log("reprovado");