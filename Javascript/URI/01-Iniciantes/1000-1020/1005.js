let firstGrade, secondGrade , averageGrade;

firstGrade = parseFloat(prompt("Digite a primeira nota"));

secondGrade =  parseFloat(prompt("Digite a segunda nota"));
averageGrade = ((firstGrade * 3.5) + (secondGrade * 7.5))/ 11.0;
console.log(`MEDIA = ${averageGrade.toFixed(5)}`);
alert(`MEDIA = ${averageGrade.toFixed(5)}`);