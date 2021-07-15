#include <iostream>
#include <list>

using namespace std;

int main()
{
    //Aula 30 Listas e seus metodos parte
    //Declaraçao
    // metodos ver aula 30 exceto push_back e push_front e pop_back e pop_front

    list<int> aula, canal , teste; // multideclaraçao
    //Criando um iterator para parte final da aula
    list<int>::iterator it;
    //
    int tam;
    tam = 10;
    //adicionar elementos na lista
    for (int i =0 ; i < tam ;i++)
    {
        //para adicionar no indice 0 usamos push front e push back para ultima
        aula.push_front(i);
    }
    for (int i =0 ; i < tam ;i++)
    {
        //para adicionar no indice 0 usamos push front e push back para ultima
        teste.push_back(i);
    }
    cout << "tamanho da lista " << aula.size() << endl;
    tam = aula.size();
   
    // Inserir elemento no indice que quiser ou qualquer parte da lista
    for (int i =0 ; i < tam ;i++)
    {
        //para adicionar no indice 0 usamos push front e push back para ultima
        aula.push_front(i);
    }
    it = aula.begin();
    // funçõa nativa advance ( nome do interator , indice do vetor) 
    advance(it,5);
    // variavel de iterator e o valor que sera inserido
    aula.insert(it,-1);
    cout << "O novo tamanho de aula: " << aula.size() << endl;
    aula.sort();
    teste.sort();
     for (int i = 0; i < tam; i++)
    {
        cout << "Lista aula: " << aula.front() << endl;
        aula.pop_front();
        cout << "Lista teste: " << teste.front()  << endl;  
        teste.pop_front();
    }
    return 0;
}