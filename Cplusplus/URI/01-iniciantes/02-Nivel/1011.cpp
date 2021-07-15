#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;
double SetSphereSize();
double CalculateSphereVolume(double sphereSize);

int main()
{
    double sphereSize; 
    sphereSize = SetSphereSize();    
    cout << "VOLUME = " << fixed << setprecision(3) << CalculateSphereVolume(sphereSize) << endl;    
    return 0;
}
double SetSphereSize()
{
    double sphereSize;
    cout << " Digite o raio da esfera." << endl;
    cin >> sphereSize >> setprecision(2) >> fixed;
    return sphereSize;
    
}
double CalculateSphereVolume(double sphereSize)
{
    double pi = 3.14159, formulaConstant = 4 / 3.0, sphereVolume;
    sphereVolume = formulaConstant * pi * pow(sphereSize, 3);
    return sphereVolume;
}