let values = [4];
for (let i = 0; i < 4; i++)
{
    values[i] = parseInt(prompt(`Digite o valor ${i + 1}`));
}
console.log("DIFERENCA = " + (values[0] * values[1] - values[2] * values[3]));
document.write("DIFERENCA = " + (values[0] * values[1] - values[2] * values[3]));