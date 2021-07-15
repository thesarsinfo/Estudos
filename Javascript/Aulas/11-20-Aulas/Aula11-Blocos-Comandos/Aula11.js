//Aula 11 - Bloco de comandos
// São as estruturas de chaves dentro de if e etc...
// São somentes exigidas se houver mais 1 linha

let num = 20;
(num > 10 ) ? res = "Maior que 10" : res = "menor que 10"; // forma correta se houver uma linha de instrução
if (num > 9)
{
    res = "Maior que nove";
    document.write(num);
    alert(num)
} else
{
    res = "Menor que nove";
    document.write(num);
    alert(num);
}

