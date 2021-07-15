#include <iostream>
#include <vector> // Biblioteca de vetores

using namespace std;

int main()
{
    /*
    Aula 42 Travbalhando com Vector que uma maneira mais moderna que usar Array.
    */
   //declaração e não prescisa especificar.
   //vector<tipo> nome(tamanho)

   vector<int> num;
   vector<int> num2;
   int tam1,tam2;
   //forma manual
   num.push_back(1); num.push_back(2); num.push_back(3); num.push_back(4);num.push_back(5);
   num2.push_back(6);num2.push_back(7);num2.push_back(8);num2.push_back(9);num2.push_back(10);
   
   //Inserindo valores 
    num.insert(num.begin(),999); // mais usado com iterator e por isso usamos um num.begin() para enganar o iterator
    //Inserindo em qualquer posição
    num2.insert(num2.begin()+3, 568);
    //inserindo no final
    num.insert(num.end(),777);
    //inserindo no penultima posição
    num2.insert(num2.end() -1,777);

    //Removendo elementos no começo
    num.erase(num.begin()+2); // usa-se os mesmo exemplo acima e metodos tambem

   //retorna o tamanho
   tam1 = num.size();
   tam2 = num2.size();
    cout << "Tamanho do vector1: " << tam1 << endl; // se imprimir mais do que voce acha é porque ja foi alocado inicialmente
    cout << "Tamanho do vector2: " << tam2 << endl; // se imprimir mais do que voce acha é porque ja foi alocado inicialmente


    //Primeiro e ultimo
   cout << "Primeiro valor de num: " << num.front() << endl;
   cout << "Ultimo valor de num: " << num.back() << endl;

   //Valor do meio
   cout << "Valor do meio: " << num.at((num.size()/2)) << endl; /*Podemos inserir a posiçao diretamente se quisemos outro 
   valor sem contas*/
    
   
   //Trocando valores entre vectors
   num.swap(num2); // R: 5678 1234
   //modificar valores inseridor
   num[3] = 4;

  
    for (int i = 0; i < num.size(); i++)
    {
        cout << num[i] << " ";
    }
    cout << endl;
    for (int i = 0; i < num2.size(); i++)
    {
        cout << num2[i] << " ";
    }
    //Usando o poo_back para retirar elementos
    while (!num.empty())
    {
        num.pop_back();
    }
    cout << endl;
    tam1 = num.size();
    cout << "Novo Tamanho do vector1: " << tam1 << endl;
    num2.clear();
    tam2 = num.size();
    cout << "Novo Tamanho do vector2: " << tam2 << endl;




    return 0;
}