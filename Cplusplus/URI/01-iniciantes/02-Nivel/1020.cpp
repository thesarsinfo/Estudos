#include <iostream>
#include <cmath>

using namespace std;
//structs
struct Timer
{
    int dataTimer, years, mounths, days; 
    int ReceiveTimeDays()
    {
        cout << "Digite o tempo em dias" << endl;
        cin >> dataTimer;
        return dataTimer;
    }
    int TransformDaysYears(int dataTimer)
    {        
        years = floor(dataTimer / 365);
        mounths = floor((dataTimer - (years * 365))/30);
        days = floor(dataTimer - (years * 365 + mounths * 30));        
    }
};

int main()
{
    Timer time;
    time.ReceiveTimeDays();
    time.TransformDaysYears(time.dataTimer);
    cout << time.years << " ano(s)" << endl;
    cout << time.mounths << " mes(es)" << endl;
    cout << time.days << " dia(s)" <<  endl;
    return 0;
}