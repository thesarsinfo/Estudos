function main ()
{
    let productsData = [], sumPrice;
    productsData = receiveData();
    sumPrice = CalculateCheckOutProducts(productsData);
    console.log("VALOR A PAGAR = R$ " + sumPrice.toFixed(2));
    alert("VALOR A PAGAR = R$ " + sumPrice.toFixed(2));
}
function receiveData()
{
    let productsReceiveData = []
    let productsData = [];   
    for (let i = 0; i < 2; i++) {
        productsReceiveData = prompt("Digite o valor").split(" ");         
        productsData = productsData.concat(productsReceiveData);
    }    
    return productsData;
}
function CalculateCheckOutProducts(productsData)
{
    let sumPrice = 0;
    for (let i = 0; i < 2 ; i++)
    {
        sumPrice += productsData[i * 3 + 1] * productsData[i * 3+ 2];
    }
    return sumPrice;
}
window.addEventListener("load", main);