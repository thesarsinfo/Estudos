#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;
double ReceiveSidesMeasurements(double sizeMensuraments[3]);
double CalculateTriagleArea(double sizeMensuraments[3]);
double CalculateCircleArea(double sizeMensuraments[3]);
double CalculateTrapeziumArea(double sizeMensuraments[3]);
double CalculateSquareArea(double sizeMensuraments[3]);
double CalculateRectangleArea(double sizeMensuraments[3]);

int main()
{
    double sizeMensuraments[3];
    ReceiveSidesMeasurements(sizeMensuraments);
    CalculateTriagleArea(sizeMensuraments);
    CalculateCircleArea( sizeMensuraments);
    CalculateTrapeziumArea( sizeMensuraments);
    CalculateSquareArea( sizeMensuraments);
    CalculateRectangleArea( sizeMensuraments);    
    return 0;
}
double ReceiveSidesMeasurements(double sizeMensuraments[3])
{
    double sideA, sideB, sideC;
    cout << "Digite os lados do A, B e C da figura." << endl;
    cin >> sideA >> sideB >> sideC >> fixed >> setprecision(2);
    sizeMensuraments[0] = sideA;
    sizeMensuraments[1] = sideB;
    sizeMensuraments[2] = sideC;   
    return sizeMensuraments[3];
}
double CalculateTriagleArea(double sizeMensuraments[3])
{
    double result = sizeMensuraments[0] * (sizeMensuraments[2] / 2);
    cout << "TRIANGULO: " << fixed << setprecision(3) << result << endl;
}
double CalculateCircleArea(double sizeMensuraments[3])
{
    double pi = 3.14159 , result;
    result = pi * pow(sizeMensuraments[2],2);
    cout << "CIRCULO: " << fixed << setprecision(3) << result << endl;
}
double CalculateTrapeziumArea(double sizeMensuraments[3])
{
    double result = ((sizeMensuraments[0] + sizeMensuraments[1]) * sizeMensuraments[2]) / 2;
    cout << "TRAPEZIO: " << fixed << setprecision(3) << result << endl;
}
double CalculateSquareArea(double sizeMensuraments[3])
{
    double result = pow(sizeMensuraments[1],2);
    cout << "QUADRADO: " << fixed << setprecision(3) << result << endl;
}
double CalculateRectangleArea(double sizeMensuraments[3])
{
    double result = sizeMensuraments[0] * sizeMensuraments[1];
    cout << "RETANGULO: " << fixed << setprecision(3) << result << endl;
}