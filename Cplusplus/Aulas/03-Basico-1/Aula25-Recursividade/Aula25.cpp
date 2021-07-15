#include <iostream>

using namespace std;

void contador(int num);
void contador2(int num , int cont = 0);
void fatorial(int num, int cont = 1, int resultado = 1);
void fibonacci(int ArrayFibo ,int resul , int numero, int conta = 0);

int main()
{   
    int num , conta;
    const int fiboTamArray = 8;
    int arrayFibo[fiboTamArray] = {0,1};
    int numero = fiboTamArray - 1;
    int resul = 0;
    conta = 0;
    contador(10);
    contador2(20);
    cout << endl << endl;
    fatorial(5,1,5);
    fibonacci(fiboTamArray ,resul, numero, conta );
    
    return 0;
}

void contador(int num) // função sem recursividade
{
    for (int i = 0; i <= num; i++)
    {
        cout << i << "\n";
    }
}
void contador2(int num , int cont) // função sem recursividade
{
    
    cout << cont << "\n";
    if(num > cont) // parametro de num é 20 na chamada
    {
        contador2(num, ++cont); //pre incremento
        //gera outro registro de ativação gerando uma nova chamada ou seja 20 posições ativadas na memoria
    }
    
}
void fatorial(int num, int cont , int resultado)
{
    resultado = resultado * (num -1);    
    if (num > cont)
    {        
        cout << resultado << endl;
        fatorial(--num, cont, resultado);
    }
}

// modo Correto
/*
    int fatorial( int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * fatorial(n - 1);
    }

    fibonacci

    for (int i = 0; i < val; i++)
    {
        cout << fibonacci(i +1) << " ";
    }
    int fibonacii (int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }else
        {
            return fibonacci(n-1) + fibonacci(n + 2);
        }
    }
*/
void fibonacci(int ArrayFibo ,int resul, int numero, int conta)
{
    //resul = resul + ArrayFibo[conta]; 

}