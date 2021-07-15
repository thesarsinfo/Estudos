#include <iostream>

using namespace std;

int main()
{
    int aValue, bValue , cValue , dValue, result;
    cout << "Digite o valor de A" << endl;
    cin >> aValue;
    cout << "Digite o valor de B" << endl;
    cin >> bValue;
    cout << "Digite o valor de C" << endl;
    cin >> cValue;
    cout << "Digite o valor de D" << endl;
    cin >> dValue;
    result = aValue * bValue - cValue * dValue;
    cout << "DIFERENCA = "<< result << endl;
    return 0;
}