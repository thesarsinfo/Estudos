//função de entrada de dados
// entrada simples

function SphereSize()
{
    sphereSize = parseFloat(prompt("Digite o tamanho da espera!"));
    return sphereSize;
}

// entrada mesma linha

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