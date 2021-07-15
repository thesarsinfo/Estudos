let totalComission , salary , totalSales;

nameEmployer = ReceiveNameEmployer();
[salary , totalSales] = ReceiveSalaryData()
calculateCommission  = CalculateCommission(totalSales);
console.log("TOTAL = R$ " + (salary + calculateCommission).toFixed(2));

function ReceiveNameEmployer()
{
    let nameEmployer;
    nameEmployer = prompt("Digite o nome do funcionario");
    return nameEmployer;
}

function ReceiveSalaryData()
{
    let receiveSalaryData = [2]
    let salary = parseFloat(prompt("Digite o salário do funcionario:"));
    let totalSales = parseFloat(prompt("Digite o total de vendas do mes"));
    receiveSalaryData[0] = salary;
    receiveSalaryData[1] = totalSales;
    return receiveSalaryData;
}
function CalculateCommission(totalSales)
{
    let commissionTax , totalCommission;
    console.log(totalSales)
    commissionTax = 0.15;
    totalCommission = ( totalSales * commissionTax);    
    return totalCommission;
}