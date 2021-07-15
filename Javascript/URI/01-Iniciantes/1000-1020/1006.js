let firstGrade, secondGrade, thirdGrade , averageGrade;

firstGrade = parseFloat(prompt("Digite a primeira nota"));
secondGrade =  parseFloat(prompt("Digite a segunda nota"));
thirdGrade =  parseFloat(prompt("Digite a terceira nota"));
averageGrade = ((firstGrade * 2) + (secondGrade * 3) + (thirdGrade * 5))/ 10.0;
console.log(`MEDIA = ${averageGrade.toFixed(1)}`);
alert(`MEDIA = ${averageGrade.toFixed(1)}`);