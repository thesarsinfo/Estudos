#include <iostream>
#include <iomanip>
using namespace std;
//Structs
struct ComsumptionTravel
{
    int hours = 0; 
    int averageSpeed = 0;
};
//Functions
void ReceiveData(int *averageSpeedPointer, int *hoursPointer);
double WasteGalons( ComsumptionTravel dataComsumption);
//Constants
#define wasteGalons 12

int main()//
{   
    int *averageSpeedPointer, *hoursPointer;
    double comsumption;
    ComsumptionTravel dataComsumption;
    dataComsumption.hours = dataComsumption.averageSpeed = 0;
    averageSpeedPointer = &dataComsumption.averageSpeed;
    hoursPointer = &dataComsumption.hours;
    
    ReceiveData(&dataComsumption.averageSpeed, &dataComsumption.hours);    
    comsumption = WasteGalons(dataComsumption);
    cout << fixed << setprecision(3) << comsumption << endl;
    return 0;
}
void ReceiveData(int *averageSpeedPointer, int *hoursPointer)
{
    ComsumptionTravel dataComsumption;
    cout << "Digite o numero de horas viajadas: " << endl;
    cin >> dataComsumption.hours;
    *hoursPointer = dataComsumption.hours;
    cout << "Digite o consumo de combustivel: " << endl;
    cin >> dataComsumption.averageSpeed;
    *averageSpeedPointer = dataComsumption.averageSpeed;    
}
double WasteGalons( ComsumptionTravel dataComsumption)
{
    double distance, comsumption;
    distance = dataComsumption.hours * dataComsumption.averageSpeed;
    comsumption = distance / wasteGalons;
    return comsumption;
}