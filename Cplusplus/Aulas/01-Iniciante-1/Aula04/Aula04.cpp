#include <iostream>
using namespace std;

int main()
{
    //tipo nome
    //tipo nome = valor;
    int vidas = 0; // 10, 25
    char letra = 'B'; // 'b' aspa unica
    char letras[20]; //vetores de letras
    double decimal = 5.2; //2.4999999
    float decimal2 = 5.2; //2.4999 menor prescisão
    bool vivo = true; // true or false
    string nome = "Saraiva"; //conjunto de caracteres
    
    //Usando um cout e cin cin é para entradas

    cout << "digite o numero de vidas: ";
    cin >> vidas;
    cout << "digite uma letra: ";
    cin >> letra;
    cout << "digite o numero flutuante: ";
    cin >> decimal;
    cout << "digite o seu nome: ";
    cin >> nome;

    cout << vidas << "\n";
    cout << letra << "\n";
    cout << decimal << "\n";
    cout << decimal2 << "\n";
    cout << vivo << "\n";
    cout << nome << "\n";
    //comentario de linha unica
    /* bloco comententado
        ainda comentado
    */

    return 0;
}