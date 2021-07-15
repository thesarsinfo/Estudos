#include <iostream>
#include <string>

using namespace std;
//Em C++ prescisamos prototipar uma função ou seja uma apresentação
void texto();
void soma(int n1, int n2);
int soma2(int n1, int n2);
void transporte(string tra[4]);

int main()
{  
    int n1, n2, res;
    string transp[4] = {"carro","moto","barco","aviao"};
    texto();
    
    //podemos chamar a funçao dentro de um for
    for(int i = 0; i < 10 ; i++)
    {
        texto();
    }
    cout << "digite um numero";
    cin >> n1;
    cout << "digite um numero";
    cin >> n2;
    soma(n1,n2);
    res = soma2(n1,n2);
    cout << "O valor de res = " << res << "\n";
    // Ou dessa forma tbm funciona
    cout << "O valor direto da funcao executada = " << soma2(n1,n2)  << "\n";
    transporte(transp);

    return 0;
}

void texto() //void é um retorno sem valor
{
    cout << endl <<"Saraiva Estudos" << endl << endl;
}
void soma(int n1, int  n2)
{
    cout << "Soma do valores: " << n1 + n2 << "\n";
    int resultado = n1 + n2;
    cout << resultado;
}

int soma2(int n1, int n2)
{
    return n1 + n2 ;
}
void transporte(string tra[4])
{
    for (int i=0; i< 4; i++)
    {
        cout << tra[i] << "\n";
    }
}