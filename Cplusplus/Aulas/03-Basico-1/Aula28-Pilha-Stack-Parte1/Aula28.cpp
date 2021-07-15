#include <iostream>
#include <stack> //trabalha com pilhas
#include <string> 

using namespace std;

int main()
{
    //primeiro elemento inserido é o ultimo a ser retirado e o ultimo inserido é o primeiro a ser retirado
    //   7  //
    //   6  //
    //   4  //
    //   3  //
    //   2  //
    //   1  //
    //////////

    stack <string> cartas;

    cartas.push("Rei de Copas");
    cartas.push("Rei de Espadas");
    cartas.push("Rei de Ouros");
    cartas.push("Rei de Paus");

    cout << "tamanho da pilha: " << cartas.size() << "\n";

    cartas.pop();
    cout << "tamanho da pilha: " << cartas.size() << "\n";
    cout << "Carta do topo: " << cartas.top() << "\n";

    cartas.pop();
    cout << "tamanho da pilha: " << cartas.size() << "\n";
    cout << " Nova Carta do topo: " << cartas.top() << "\n";

    
    

    return 0;
}