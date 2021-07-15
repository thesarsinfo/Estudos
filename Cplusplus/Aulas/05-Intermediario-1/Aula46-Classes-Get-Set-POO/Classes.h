#ifndef CLASSES_H_INCLUDED
#define CLASSES_H_INCLUDED
#include <string>
using namespace std;

class Veiculo
{    
public:
    
    int tipo;
    Veiculo(int tipo);
    int GetVelocidadeMaxima();
    bool GetLigado();
    void SetLigado(int l);
private:
/*
todos elementos privados so podem ser manipulados pela classe
Ex: para manipular a velocidade ou nome temos que criar um metodo para alterar ou chama-los
*/
    string nome;
    int velocidade;
    int velocidadeMaxima;
    bool ligado;
    void SetVelocidadeMaxima(int vm);
};
Veiculo::Veiculo(int tipo)// 1 = Carro 2 = Aviao 3 = Navio
{
    this->tipo= tipo;
    if (this->tipo == 1)
    {
        nome ="Carro";
        SetVelocidadeMaxima(220);
        SetLigado(0);
    }
    else if (this->tipo == 2)
    {
        nome ="Aviao";
        SetVelocidadeMaxima(880);
        SetLigado(0);
    }
    if (this->tipo == 3)
    {
        nome ="Navio";
        SetVelocidadeMaxima(120);
        SetLigado(0);
    }
}
int Veiculo::GetVelocidadeMaxima()
{
    return velocidadeMaxima;
}
void Veiculo::SetVelocidadeMaxima(int vm)
{
    velocidadeMaxima = vm;
}
bool Veiculo::GetLigado()
{
    return ligado;
}
void Veiculo::SetLigado(int l)
{
    if (l == 1)
    {
        ligado =true;
    }
    else
    {
        ligado = false;
    }
}

#endif //CLASSES_H_INCLUDED