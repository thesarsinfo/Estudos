//Getter e setter são metodos para setar e obter infomações nas propriedades
class Carro 
{    
    corFora = null
    //definindo alerta com endereço de memoria unico
    static alerta = true;
    constructor(marca,modelo,cor)
    {        
        this.marca = marca
        this.modelo = modelo
        this.cor = cor
        this.ligado = false;
        this.km = 0;
        this.consumo = 10
        this.mensagem = ""
    }
    info()
    {
        console.log("Marca.......: " + this.marca);
        console.log("Modelo......: " + this.modelo);
        console.log("Cor.........: " + this.cor);
        console.log("Ligado......: " + (this.ligado ? "Sim" : "Não"));
        console.log("Km..........: " + this.km);
        console.log("Consumo Km/l: " + this.consumo);
        console.log("alerta......: " + (this.getAlerta ? "Sim" : "Não"));

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
    //Metodo Padrao
    setCombustivel(value)
    {
        this.consumo = value
    }
    setAlerta(type)
    {
        Carro.alerta = type
    }

    //Metodo usando set
    set defineCombustivel(value)
    {
      this.mensagem = (value < 5 || value > 30) ? "Valor inapropriado" : this.consumo = value
        
        console.log(this.mensagem + " o valor atual é: " + this.consumo);
    }    
    //Usando metodo getter
    get pegaValorConsumo()
    {
        return console.log("O valor do consumo é: " + this.consumo);        
    }
    get getAlerta()
    {
        return Carro.alerta;
    }

}

let carroUm = new Carro("Fiat","Uno","Vermelho");
let carroDois = new Carro("Honda","HRV","Prata");
let carroTres = new Carro("Vw","Golf","Branco");
let carroQuatro = new Carro("GM","Camaro", "Amarelo");

carroUm.ligar()
carroUm.setCombustivel(11);
//chamando a função set como se fosse uma variavel
carroUm.defineCombustivel = 9
//Obter valores
carroUm.pegaValorConsumo;
//Definindo valor de alerta em 1 dos carros como false alterar para todos
//carroUm.setAlerta(false)
//usando diretamente na classe
//Carro.alerta = true;

carroUm.info();
carroDois.info();
carroTres.info();
carroQuatro.info();
console.log(Carro);