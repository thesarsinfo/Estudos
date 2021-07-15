//Aula 09 If com multiplos retornos;
let nota = 59;
let res;
if (nota >= 95)
{
    res = "Aluno Aprovado com louvor";
} else if ((nota >= 60) && (nota < 95))
{
    res = "Aluno Aprovado";
} else if ((nota >= 40))
{
    res = "Aluno em recuperação";
} else if ((nota >= 20))
{
    res = "Aluno reprovado";
} else 
{
    res = "Aluno reprovado com louvor";
}
document.write(res);