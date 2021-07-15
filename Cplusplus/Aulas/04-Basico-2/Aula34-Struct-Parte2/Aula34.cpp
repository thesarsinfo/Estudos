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

    void insere(string stNome, string stCor, int stPotencia, int stVelocidadeMaxima)
    {
        nome = stNome;
        cor = stCor;
        potencia = stPotencia;
        velocidadeMaxima = stVelocidadeMaxima;
    }
    void Mostra()
    {
        cout << "Nome do carro: " << nome << endl;
        cout << "Cor do carro: " << cor << endl;
        cout << "Potencia do carro: " << potencia << endl;
        cout << "Velocidade Maxima do carro: " << velocidadeMaxima << endl;
    }
    void MudaVelocidade(int mudaVelocidade)
    {
        int velocidade;
        velocidade = mudaVelocidade;
        if (velocidade > velocidadeMaxima)
        {
            velocidade = velocidadeMaxima;
        }
        if (velocidade < 0)
        {
            velocidade = 0;
        }
    }    
};

int main()
{
    /* Aula 33 Struct
        Serve para guardar metodos, variaveis.
        Parecido com objetos em javascript.
    */
   //Instanciamento da struct
   Carro car1, car2,car3,car4;  
   //Atribuindo as variaveis
   car1.insere("tornado","Vermelho", 450 , 350);
   car2.insere("Luxos","Preto", 350 , 250);
   car1.Mostra();
   car2.Mostra();
    
   return 0;
}