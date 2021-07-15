#include <iostream>
#include <string>
#include <queue>

using namespace std;

int main()
{
    //Aula 30 sobre as Queue ou fila ou seja o primeiro a entrar primeiro a sair
    //ultimo a entrar ultimo a sair.
    /* metodos
        empty
        size
        front
        back
        push
        pop
    */

    queue <string> cartas;
    if ( cartas.empty())
    {
        cout << "fila vazia" << endl << endl;
    } else
    {
        cout << "fila com cartas" << endl << endl;
    }
    cartas.push("Rei de Copas");
    cartas.push("Rei de Espadas");
    cartas.push("Rei de Ouros");
    cartas.push("Rei de Paus");
    cout << "tamanho da fila: " << cartas.size() << "\n";
    while (!cartas.empty())
    {         
        cout << "tamanho da fila: " << cartas.size() << "\n";        
        if (cartas.size() > 1)
        {            
            cout << "Primeira Carta da fila: " << cartas.front() << "\n";
            cout << "Ultima Carta da fila: " << cartas.back() << "\n";
            cartas.pop();
        } else
        {   
            cout << "Primeira Carta da fila: " << cartas.front() << "\n";
            cout << "Ultima Carta da fila: " << cartas.back() << "\n";
            cartas.pop();
            cout << "fila vazia" << endl;
        }
    }
    return 0;
}