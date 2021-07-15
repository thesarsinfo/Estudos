// Aula 10  - If aninhado ou seja um if dentro do outro
let nota, res;

if (nota >= 60)
{
    if (nota >= 95)
    {
        res = "Aprovado com louvor";
    } else
    {
        res = "Aprovado";
    }
} else if (nota >= 40)
{
   res = "Aluno em recuperação";
} else
{
    if ( nota >= 20)
    {
        res = "reprovado"
    } else
    {
        res = "reprovado com louvor"
    }
}
document.write(res);
