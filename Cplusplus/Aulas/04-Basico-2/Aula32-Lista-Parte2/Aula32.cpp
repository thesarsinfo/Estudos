#include <iostream>
#include <list>

using namespace std;

int main()
{
    /*
    inserçao , erase 
    */
    list<int> aula , teste;
    list<int>::iterator it;
    int tam;
    tam = 10;

    teste.push_front(9);
    teste.push_front(9);
    teste.push_front(9);
    teste.push_front(9);


     for (int i =0 ; i < tam ;i++)
    {
        //para adicionar no indice 0 usamos push front e push back para ultima
        aula.push_front(i);
    }
    it = aula.begin();
    advance(it,3); //advance serve para avançar o numero do iterator
    aula.insert(it,0);
    //Para remover um item temos que usar o metodo erase
    //erase(pos_do_iterator(int))
    aula.erase(--it); // -- antes é para poder aplicar logo o codigo
    //para remover outro elemento temos que criar outro advance e podemos usar um for para isso.

   
    //Metodo Merge
    // lista inicial.merge(lista_quero_copiar)
    aula.merge(teste);

    cout << "tamanho da lista " << aula.size() << "\n\n";
    tam = aula.size();
    for (int i = 0; i < tam; i++)
    {
        cout << "Lista aula: " << aula.front() << endl;
        aula.pop_front();
    }

     //Metodo Clear
    aula.clear(); // remove tudo ou seja limpa a fila.
    return 0;
}