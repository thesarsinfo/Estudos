#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;
struct Bhaskara
{
    double a,b,c, squareRootOne, squareRootTwo;

    void NumbersData()
    {
        cout << "Digite os numeros" << endl;
        cin >> a >> b >> c;
    }
    double VerifyNumber()
    {
        double verifyNumber;
        verifyNumber = pow(b,2) - 4 * a * c;
        return verifyNumber;
    }
    void CalculateSquareRoots( double verifyNumber)
    {        
        
        if (a == 0)
        {
            cout << "Impossivel calcular" << endl;

        }else if (verifyNumber < 0)        
        {
            cout << "Impossivel calcular" << endl;
        }else
        {
            squareRootOne = (-b + sqrt(verifyNumber)) / (2 * a);
            squareRootTwo = (-b - sqrt(verifyNumber)) / (2 * a);
            cout << "R1 = " << fixed << setprecision(5) << squareRootOne << endl;
            cout << "R2 = " << fixed << setprecision(5) << squareRootTwo << endl;
        }
    }
};

int main()
{
    double verifyNumber;
    Bhaskara bhaskara;
    bhaskara.NumbersData();
    verifyNumber = bhaskara.VerifyNumber();
    bhaskara.CalculateSquareRoots(verifyNumber);
    return 0;
}