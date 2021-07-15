#include <iostream>
using namespace std;

int main()
{
    /* 
        Aula 18 vetor
        tipo nome[tamanho];
        int carros[5];
        mesma coisa que 
        int carro0, carro1, carro2, carro3, carro4
        index do vetor sempre começa pelo 0
    */

   int vetor[5];
   int i ;

   vetor[0] = 10; //
   vetor[1] = 20; //
   vetor[2] = 30; //
   vetor[3] = 40; //
   vetor[4] = 50; //

   cout << vetor[6] << endl; 
   // valor aleatorio. O compilador g++ não consegue entender que saiu fora de escopo
   // tome cuidado ao compilar valores pq pode imprimir lixo e perder confiabilidade no programa
    for (i = 0 ; i < 5; i++)
    {
        cout << vetor[i] << endl;
    }
    // Usando for pelo tamanho do array usando o metodo sizeof mas verifique a condição de cada tipo int, string
    //Para int dividimos por 4 ou melhor usar a forma de baixo que é mais seguro pq pode mudar de sistema operacional
    for (i=0; i < sizeof(vetor)/sizeof(vetor[0]) ; i++)
    {
        cout << vetor[i] << endl;
    }
    // outra forma declarativa
    
    int vetorial[5] = {10,20,30,40,50};
    const int teste = 5; 
    int vetorzinho[teste];


    return 0;
}