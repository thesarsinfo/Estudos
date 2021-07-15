#include <iostream> //biblioteca para comandos basicos de terminal

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    // AUla 16 - Comando Do while
    // Ele executa as instruções primeiro e depois verifica a condiçao do loop
    cout << "Aula 16" << endl;
    
    cout << "Aula 14" << endl;
    int n = 10, m = 0;
    while( n < 10) 
    {
        cout << n << endl;
        n++;
    }
    cout << "Rotina  1 finalizada" << endl;
    cout << "Rotina  2 Inicializada" << endl;
    do
    {
        cout << n << endl;
        n++;
    } while (  n < 10);
    
    
    
    system("pause");
    return 0;
}