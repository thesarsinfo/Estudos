#include <iostream>

using namespace std;
//declarando uma variavel global constante
//# nome desse simbolo é diretiva.
#define pi 3.1415
#define canal cout << "Estudos do Saraiva \n\n"
//Ou você define ; no define ou na linha de codigo

int main()
{
    //declaração muitiplas e inicialização multipla tambem
    int vidas = 3, tiros = 500, life = 100;
    //outra forma porem não usual
    int vidasMultiplas; int tirosMultiplos; int lifeMultiplos;

    //Declarando com inicialização
    string nome = "thiago", nomeMeio = "Jorge", sobrenome = "Saraiva";
    cout << sobrenome << nome <<  "\n\n" << "digite o nome: ";
    cin >> nome ;
    //Chamando a contante pi
    cout << pi;
    canal;

    return 0;
}