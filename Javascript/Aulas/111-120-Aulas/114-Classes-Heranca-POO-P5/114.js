//Getter e setter são metodos para setar e obter infomações nas propriedades
class Carro 
{    
    constructor(tipoCarro ,tipoCombustivel)
    {        
        this.tipoCarro = tipoCarro; //1 - Passeio 2 - Transporte, 3 = Combate 
        this.qtCombustivel = 100        
        this.ligado = false;
        this.tipoCombustivel = tipoCombustivel // 1 - Gasolina 2 - Diesel 3- Etanol     
        this.mensagem = ""  
    }

    info()
    {
        console.log("Qtde Combustivel.....: " + this.qtCombustivel);        
        console.log("Ligado...............: " + (this.ligado ? "Sim" : "Não"));
        console.log("Tipo de Combustivel..: " + this.tipoCombustivel);
        this.tipoCarro == 1 ? 
        console.log("Tipo de carro........: Passeio") :
        this.tipoCarro == 2 ?
        console.log("Tipo de carro........: Transporte") :
        console.log("Tipo de carro........: Combate");
    }

    set setLigado(bool)
    {
        this.ligado = bool;
    }
    get getLigado()
    {
        return this.ligado 
    }  
    
    set setComb(value)
    {
      this.mensagem = (value < 0 || value > 100) ? "Valor inapropriado" : this.qtCombustivel = value
        
        console.log(this.mensagem + " o valor atual é: " + this.qtCombustivel);
    }    
    get getComb()
    {
        return this.qtCombustivel;
    }    
   
}
class CarroCombate extends Carro
{
    //super significa que estou acessando o construtor da classe pai Carro
    constructor(potTiro)
    {        
        super(3,2)
        
        this.tiros = 1000
        this.potTiro = potTiro;
        this.blindagem = 100;
            
    }
    info()
    {
        super.info()
        console.log("Qtde do tiro...: " + this.tiros)    
        console.log("Pot. do Tiro...: " + this.potTiro)    
        console.log("Blindagem......: " + this.blindagem)    
        console.log("--------------------------------");
    }
}
class CarroTransporte extends Carro
{
    constructor()
    {
        super(2,1)
    }
}
let carroUm = new CarroCombate(1000);
let carroDois = new CarroTransporte()
carroUm.setLigado = true;
carroUm.info();
carroDois.info();





