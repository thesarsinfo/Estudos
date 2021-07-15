#include <iostream>

using namespace std;

void soma(int n1, int n2);
void soma();

int main()
{
    //podemos teer n funções com mesmo nome e ações diferentes
    //O que não pode ser igual é o nome do parametro
    soma(20,30);
    soma();

    return 0;
}
void soma(int n1, int n2)
{
    int re;
    re = n1 + n2;
    cout << "Soma de " << n1 << " Com " << n2 << " = " << re << "\n\n"; 
}

void soma()
{
    int n1 , n2, re;
    n1 = 10;
    n2 = 20;
    re = n1 + n2;
    cout << "Soma de " << n1 << " Com " << n2 << " = " << re << "\n\n"; 
}