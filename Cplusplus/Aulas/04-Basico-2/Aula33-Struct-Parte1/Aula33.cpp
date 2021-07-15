#include <iostream>
#include <string>

using namespace std;
// Criaçao da estrutura da struct
struct Carro
{
    string nome;
    string cor;
    int potencia;
    int velocidadeMaxima;
    
};


int main()
{
    /* Aula 33 Struct
        Serve para guardar metodos, variaveis.
        Parecido com objetos em javascript.
    */
   //Instanciamento da struct
   Carro car1;
   Carro car2;
   //Atribuindo as variaveis
   car1.nome = "Tornado";
   car1.cor = "Vermelho";
   car1.potencia = 450;
   car1.velocidadeMaxima = 350;

   car2.nome = "Luxos";
   car2.cor = "Preto";
   car2.potencia = 250;
   car2.velocidadeMaxima = 260;
    //impresao de uma struct
   cout << "Nome do carro: " << car1.nome << endl;
   cout << "Cor do carro: " << car1.cor << endl;
   cout << "Potencia do carro: " << car1.potencia << endl;
   cout << "Velocidade Maxima do carro: " << car1.velocidadeMaxima << endl;

   cout << "Nome do carro: " << car2.nome << endl;
   cout << "Cor do carro: " << car2.cor << endl;
   cout << "Potencia do carro: " << car2.potencia << endl;
   cout << "Velocidade Maxima do carro: " << car2.velocidadeMaxima << endl;
   

    return 0;
}