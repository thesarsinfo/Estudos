#include <iostream>

/*
    Aula 38 -Associaçao de ponteiros a funções e alterando a variavel 
*/

using namespace std;
void somar(float *var, float valor); 
void iniciarVetor(float *veto);

int main()
{
    float num = 0;
    float vetor[5];
    somar(&num,15); // colocamos que num esta atrelado ao ponteiro var isso garante um retorno da função void e imprimimos 
    // os valor da função void;
    iniciarVetor(vetor);
    cout << num << endl;
    for (int i = 0; i < 5; i++)
    {
        cout << vetor[i] << endl;
    }
    
    return 0;
}
void somar(float *var, float valor) //var foi declarado como ponteiro e var recebe o valor de num que é 0
{
    *var += valor; // vai operar no endereço de memoria do num.
}
void iniciarVetor(float *veto)
{
    veto[0] = 0;
    veto[1] = 1;
    veto[2] = 2;
    veto[3] = 3;
    veto[4] = 4;
}

