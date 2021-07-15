#include <iostream> //biblioteca para comandos basicos de terminal
#include <cstdlib>
using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    // Aula 12 > operador ternario de um if 
    // Uso mais rápido e mais simples
    //(expressao) ? valor1 : valor 2;
    cout << "Aula 12" << endl;
    
    int n1, n2, nota, x;
    string res;
    x = 5;
    cout << "Digite a primeira nota" << endl;
    cin >> n1;
    cout << "Digite a segunda nota" << endl;
    cin >> n2;
    nota = n1 + n2;

    // >= 60 Aprovado
    // <  60 Reprovado;

    (nota >= 60) ? res = "Aprovado" : res = "Reprovado";
    cout << endl << "Situacao do aluno: " << res << endl;

    cout << "Usando variavel" << endl;
    //res2 = (nota >= 60) ? "Aprovado" : "Reprovado"; Aqui da erro pq res2 é int
    res = (nota >= 60) ? "Aprovado" : "Reprovado";
    cout << endl << "Situacao do aluno: " << res << endl;

    // Revisando o conceito de GOTO e ternario
    voltanotempo:
    system("cls");
    cout << "Digite o valor de n1" << endl;
    cin >> n1;
    (n1 >= 9) ? x++ : x--;
    cout << "O valor de X = " << x << endl;
    cout << "Gostaria de sair [s/n]";
    cin >> res;
    if (res == "s")
    {
        goto voltanotempo;
    } 


    system("pause");
    return 0;
}