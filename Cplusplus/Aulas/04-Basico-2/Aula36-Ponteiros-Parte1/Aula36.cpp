#include <iostream>
#include <string>
using namespace std;

int main()
{
    /*
    Ponteiros serve para armazenar o endereço da variavel o endereço externo e indepedente do escopo

        endereço inicial    tipo        valor       nome
            1001            int           4         num         
            1002
            1003
                            ponteiro deve ser do mesmo tipo da variavel apontada.
                            & = operador de endereço
                            int *pn;                            
                            pn = &num;
                            cout << pn; // 1000
                            cout << *pn; // 4
    */
        string veiculo = "Carro";
        string *ponteiroVeiculo; // armazena o endereço de memoria       

        ponteiroVeiculo = &veiculo;
        cout << ponteiroVeiculo << endl << &veiculo << endl;
        cout << veiculo << endl;
        //trocando o valor da memoria.
        *ponteiroVeiculo = "Moto"; // no endereço apontado adicione o valor motos
        cout << veiculo << endl << *ponteiroVeiculo << endl;

    return 0;
}