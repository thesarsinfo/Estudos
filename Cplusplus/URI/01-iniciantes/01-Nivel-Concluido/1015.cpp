#include <iostream>
#include <iomanip>
#include <math.h>

using namespace std;
double GetXYValues ( double xYValue[4]);
void CalculateDistance(double xYValue[4]);

int main()
{   
    double xYValue[4] = {0,0,0,0};
    GetXYValues(xYValue);
    CalculateDistance(xYValue);    
    return 0;
}
double GetXYValues ( double xYValue[4])
{   
    for (int i = 0; i < 2; i++)
    {
        cout << "Digite os valores de X1 e Y1 " << endl;
        cin >> xYValue[i] >> xYValue[i+2] >> setprecision(1) >> fixed; 
    }   
    return xYValue[4];     
}
void CalculateDistance(double xYValue[4])
{
    double distance, value ,result = 0;
    for (int i = 0; i < 2; i++)
    {
        value = xYValue[i * 2 + 1] - xYValue[i*2];
        result += pow(value, 2);                     
    }
    distance = sqrt(result);    
    cout << fixed << setprecision(4) << distance << endl;
}