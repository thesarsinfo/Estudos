let idWorker , workedHours, hourlywages;
idWorker = parseInt(prompt("Digite o numero do funcionario"));
workedHours = parseInt(prompt("Digite as horas trabalhadas do funcionario"));
hourlywages = parseFloat(prompt("Digite o valor hora do funcionario"));


console.log("NUMBER = " + idWorker );
console.log("SALARY = U$ " + (hourlywages * workedHours).toFixed(2));