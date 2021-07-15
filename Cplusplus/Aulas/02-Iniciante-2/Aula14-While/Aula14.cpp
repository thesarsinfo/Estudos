#include <iostream> //biblioteca para comandos basicos de terminal

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    //Aula 14 = Aula de comando de laço while;
    // Muito usado quando não sabemos o tamanho do loop
    cout << "Aula 14" << endl;
    int n = 0, m = 0;
    while( n < 10) 
    {
        cout << n << endl;
        n++;
    }
    cout << "Rotina  1 finalizada" << endl;
    cout << "Rotina  2 Inicializada" << endl;

     
    while( (m-= 2 ) > -10)
    {
        cout << "Saraiva Estudos - " << m  << endl;
        
    }
    system("pause");
    return 0;
}