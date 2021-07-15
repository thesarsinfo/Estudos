#include <iostream> //biblioteca para comandos basicos de terminal

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    // Aula 09 -- Comando de decisão IF Else - Parte 1
    //Teste Lógico
    // > ,<, >= , <=, ==, != 
    int num = 10;
    int num2 = 50;
    char opc = 's';

    if (num > 10)
    {
        cout << "Valor de num maior que 10" << endl;
    } else
    {
        cout << "Condicao nao atendida" << endl;
    }
    if (num > num2)
    {
        cout << "resultado verdadeiro " << endl;
    } else
    {
        cout << "Resultado falso" << endl;
    }
    return 0;
}