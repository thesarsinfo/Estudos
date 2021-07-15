sidesReceiveData = ReceiveData();

console.log("TRIANGULO: " + CalculateTriagleArea(sidesReceiveData).toFixed(3));
console.log("CIRCULO: " + CalculateCircleArea(sidesReceiveData).toFixed(3));
console.log("TRAPEZIO: " + CalculateTrapeziumArea(sidesReceiveData).toFixed(3));
console.log("QUADRADO: " + CalculateSquareArea(sidesReceiveData).toFixed(3));
console.log("RETANGULO: " + CalculateRectangleArea(sidesReceiveData).toFixed(3));

function ReceiveData()
{
    let sidesReceiveData = [];       
    sidesReceiveData = prompt("Digite o valor do lado A, B, C com espaços!").split(" ");
    for (let i = 0; i < sidesReceiveData.length; i++) {
        sidesReceiveData[i] = parseFloat(sidesReceiveData[i]);        
    }        
    return sidesReceiveData;
}
function CalculateTriagleArea(sidesReceiveData)
{
     return  area = sidesReceiveData[0] * sidesReceiveData[2] / 2;
}
function CalculateCircleArea(sidesReceiveData)
{
    const pi = 3.14159;
    return  area = pi * Math.pow(sidesReceiveData[2] , 2);
}
function CalculateTrapeziumArea(sidesReceiveData)
{    
    return area = ((sidesReceiveData[0] + sidesReceiveData[1]) * sidesReceiveData[2])/ 2
}
function CalculateSquareArea(sidesReceiveData)
{
    return area = Math.pow(sidesReceiveData[1], 2);
}
function CalculateRectangleArea(sidesReceiveData)
{
    return area = sidesReceiveData[0] * sidesReceiveData[1];
}