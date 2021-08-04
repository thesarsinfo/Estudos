
//Conceitos Orientação a Objetos e seu paradigma de programação
/*
É uma coleção de objetos que podem se conectar entre si ou não
Classe é um esqueleto do objeto
Objeto é uma instacia real da classe
e por isso qunado instanciamos podemos criar varios novo objetos
*/

//Criação de classe 
class Carro //podemos associar a uma variavel diretamente
{
//Metodo construtor chama automaticamente quando instanciado
//podemos setar as variaveis da classes (chamamos de propriedades) e não usamos let,var ou const
    
    corFora = null
    constructor(cor)
    {
        //alert("ola, sou um novo carro");
        //Dentro do contrutor usamos this para criar uma nova propriedade
        this.cor = cor
        console.log("ola, sou um novo carro da cor: " + this.cor);
    }

}
//instanciar a classe em um objeto
let carroUm = new Carro("Vermelho"); //Cada objeto tem comportamento individual um não intefere no
//outro
//mostrando seus elementos
console.log(carroUm);
let carroDois = new Carro("Amarelo");//podemos criar prototipos fora da classe original 
let carroTres = new Carro("Verde");
let carroQuatro = new Carro("Branco");
