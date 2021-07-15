#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

string ReceiveNameEmployer();
double ReceiveSalaryData(double salaryData[2]);
double CalculateCommission(double salaryData[2]);

int main()
{
    string nameEmployer;
    double salaryData[2] , totalComission;
    
    nameEmployer = ReceiveNameEmployer();
    ReceiveSalaryData(salaryData);
    totalComission = CalculateCommission(salaryData);
    cout << "TOTAL = R$ " << fixed << setprecision(2)  << (salaryData[0] + totalComission) << endl;
    
    
    return 0;

}
string ReceiveNameEmployer()
{
    string nameEmployer;    
    cout << "Digite o nome do funcionario" << endl;
    cin >> nameEmployer;    
    return nameEmployer;
}

double ReceiveSalaryData(double salaryData[2])
{
    double salary, totalSales;
    
    cout << "Digite o salario do funcionario" << endl;
    cin >> salary;  
    cout << "Digite o salario do funcionario" << endl;
    cin >> totalSales;
    salaryData[0] = salary;
    salaryData[1] = totalSales; 
    return salaryData[2];
}
double CalculateCommission(double salaryData[2])
{
    double commissionTax , totalCommission;
    commissionTax = 0.15;
    totalCommission = ( salaryData[1] * commissionTax);    
    return totalCommission;
}
