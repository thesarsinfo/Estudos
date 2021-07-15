#include <iostream>
#include <iomanip>

using namespace std;
int GetFuelComsuption ( double consumeDistance[2]);
void CalculateFuelComsuption(double consumeDistance[2]);

int main()
{   
    double consumeDistance[2];
    GetFuelComsuption(consumeDistance);
    CalculateFuelComsuption(consumeDistance);
    
    return 0;
}
int GetFuelComsuption ( double consumeDistance[2])
{    
    cout << " Digite a distancia percorrida" << endl;
    cin >> consumeDistance[0]; 
    cout << " Digite a quantidade de combustivel consumido" << endl;
    cin >> consumeDistance[1] >> setprecision(1) >> fixed;  
    return consumeDistance[2];     
}
void CalculateFuelComsuption(double consumeDistance[2])
{
    double comsuption;
    comsuption = consumeDistance[0] / consumeDistance[1];
    cout << fixed << setprecision(3) << comsuption  << " km/l" << endl;
}