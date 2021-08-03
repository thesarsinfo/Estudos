
const Carro = 
{
    marca:"VW",
    modelo:"Golf", 
    info:function()
    {
        console.log("Marca: " + this.marca)
        console.log("Modelo: " + this.modelo)
    }
}

let c2 = Object.create(Carro);
let c3 = Object.create(Carro);
c2.info();

console.log("---Apos Primeira impressao---")
/*
console.log(Carro.marca);
console.log(Carro.modelo);
*/
console.log(Carro["marca"]);
console.log(Carro["modelo"]);
c2.marca = "Honda";
c2.modelo = "HRV";
c3.marca = "Fiat";
c3.modelo = "Toro";
//Utilizando anotação de vetor
Carro["marca"]= "GM"
Carro["modelo"]= "Camaro"
Carro.info();
c2.info();
c3.info();

//Mesclado objetos literais em 1 só.
console.log("--------Mesclando objetos ---------")

const Veiculo = 
{
    marca:"VW",
    modelo:"Golf", 
    cor:"Branco",
    info:function()
    {
        console.log("Marca: " + this.marca)
        console.log("Modelo: " + this.modelo)
    }
}
const Caracteristicas =
{
    cor:"Cinza",
    cambio:"Automático"
}
//Deletando propriedades de um objeto
delete Caracteristicas.cor;

const Carros = Object.assign(Veiculo,Caracteristicas);
console.log(Carros);
Carros.info(); // propriedades e metodos todos acesssiveis exceto os deletados

let {marca,cambio} = Carros
//Mudando a propriedade acima sem instancia como no inicio
marca = "Honda"
cambio = "Manual"
console.log(marca)
console.log(cambio)
