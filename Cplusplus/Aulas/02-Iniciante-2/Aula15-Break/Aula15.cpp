#include <iostream> //biblioteca para comandos basicos de terminal

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    //Aula 15 Comando break
    // Usado para interomper loops
    cout << "Aula 15 " << endl;

    int cont;
    cont = 0;
    while (cont++ < 1000 )
    {
        cout << cont << endl;
        if (cont == 500)
        {   
            cout << "Chegou a 500 e programa finalizado";
            break;
        }
    }
    
    
    system("pause");
    return 0;
}