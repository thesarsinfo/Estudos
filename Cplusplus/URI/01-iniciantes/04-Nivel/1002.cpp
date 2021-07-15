#include <iostream>
#include <iomanip>
#include <cmath>
 
using namespace std;
#define pi 3.14159
 
int main()
{
    double ray,area;    
    cout << fixed;   
    cout << "Digite o tamanho do raio: ";
    cin >>  ray >> setprecision(2);
    area = pi * pow(ray , 2);
    cout << "A=" << setprecision(4) << area << endl; 
}