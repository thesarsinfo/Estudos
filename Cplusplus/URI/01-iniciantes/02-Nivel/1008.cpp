#include <iostream>
#include <iomanip>
using namespace std;
int main()
{   
    int idWorker , workedHours;
    double hourlywages;
    cout << "Digite o numero do funcionario" << endl;
    cin >> idWorker;
    cout << "Digite as horas trabalhadas do funcionario" << endl;
    cin >> workedHours;
    cout << "Digite o valor hora do funcionario" << endl;
    cin >> hourlywages;
    cout << "NUMBER = " << idWorker << endl;
    cout << "SALARY = U$ "<< fixed << setprecision(2) << (hourlywages * workedHours) << endl;
    return 0;
}