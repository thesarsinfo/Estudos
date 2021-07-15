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
        cout << "\nNome do carro: " << nome << endl;
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
   // Aula 35
    Carro *carros = new Carro[5]; // criando array
   //Instanciamento da struct
   Carro car1, car2,car3,car4, car5;  
    carros[0] = car1;
    carros[1] = car2;
    carros[2] = car3;
    carros[3] = car4;
    carros[4] = car5;

    carros[0].insere("Tornado","Vermelhos", 450 , 350 );
    carros[1].insere("Luxos","Preto",250 ,260 );
    carros[2].insere("Familia","Prata", 150 , 180);
    carros[3].insere("Trabalho","Branco", 80 ,120 );
    carros[4].insere("Padrao","Cinza",100 ,150 );

    for (int  i = 0; i < 5;i++)
    {
        carros[i].Mostra();
    }
    

    
    
   return 0;
}