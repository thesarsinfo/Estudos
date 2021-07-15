#include <iostream>
#include <string>
#include "Classes.h"

using namespace std;

int main()
{
    Veiculo *vei1 = new Veiculo(1);
    Veiculo *vei2 = new Veiculo(2);
    Veiculo *vei3 = new Veiculo(3);
    
    vei1->SetLigado(0);
    vei2->SetLigado(1);
    vei3->SetLigado(0);
    cout << vei1->GetVelocidadeMaxima() << endl;
    cout << vei2->GetVelocidadeMaxima() << endl;    
    cout << vei3->GetVelocidadeMaxima() << endl;
    if (vei1->GetLigado() == 1)
    {
        cout << "Veiculo Ligado" << endl;
    }    
    else
    {
        cout << "Veiculo Desligado" << endl;
    }
    if (vei2->GetLigado() == 1)
    {
        cout << "Veiculo Ligado" << endl;
    }    
    else
    {
        cout << "Veiculo Desligado" << endl;
    }
      if (vei3->GetLigado() == 1)
    {
        cout << "Veiculo Ligado" << endl;
    }    
    else
    {
        cout << "Veiculo Desligado" << endl;
    }

    return 0;
}