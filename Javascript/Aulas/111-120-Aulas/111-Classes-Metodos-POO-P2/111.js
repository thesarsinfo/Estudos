class Carro 
{    
    corFora = null
    constructor(marca,modelo,cor)
    {        
        this.marca = marca
        this.modelo = modelo
        this.cor = cor
        this.ligado = false;
        this.km = 0;
        this.consumo = 10
        
    }
    info()
    {
        console.log("Marca.......: " + this.marca);
        console.log("Modelo......: " + this.modelo);
        console.log("Cor.........: " + this.cor);
        console.log("Ligado......: " + (this.ligado ? "Sim" : "Não"));
        console.log("Km..........: " + this.km);
        console.log("Consumo Km/l: " + this.consumo);
        console.log("--------------------------------");

    }
    ligar()
    {
        this.ligado = true;
    }
    desligar()
    {
        this.ligado = false
    }   
}

let carroUm = new Carro("Fiat","Uno","Vermelho");
let carroDois = new Carro("Honda","HRV","Prata");
let carroTres = new Carro("Vw","Golf","Branco");
let carroQuatro = new Carro("GM","Camaro", "Amarelo");
/*
Definindo diretamente o valor da propriedade
carroUm.cor = "Rosa";
carroDois.cor = "Branco";
carroTres.cor = "Prata";
carroQuatro.cor = "Amarelo";
*/
carroUm.ligar()
carroUm.info();

carroDois.info();
carroTres.info();
carroQuatro.info();
console.log(Carro);

