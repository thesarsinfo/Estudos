#include <iostream>
#include <string.h> // Vamos usar para comparação de strings
#include <stdlib.h>

using namespace std;
// Argc guarda a quantidade de parametros isso vemos quando usamos dotnet new etc
// *argv é um ponteiro onde vou armazenar os meus argumentso na argv
int main(int argc, char *argv[] )
{
    cout << endl << argv[0] << endl; //Aula21.exe // Nome do program sempre no indice 0
    
    cout << argc << "\n";
    //tratando parametros
    if (argc > 1)
    {
        cout << endl << argv[1] << endl; // // nome do parametro que passei ao executar
        if (!strcmp(argv[1], "sol")) // O metodo strcmp valor retorna 0 se os valores forem iguais e 1 se
        //forem difetentes e por isso usamos o operador de negação
        {
            cout << "Vou a praia! \n\n";
        }else if (!strcmp(argv[1], "nublado"))
        {
            cout << "Vou ao cinema; \n\n";
        } else
        {
            cout << "Vou ficar em casa!";
        }
    } else
    {
        cout << "Nenhum parametro informado";
    }
    system("pause");
    return 0;
}