#include <iostream>
#include <cmath>

using namespace std;
//structs
struct Timer
{
    int dataTimer, hours, minutes, seconds; 
    int ReceiveTimeSeconds()
    {
        cout << "Digite o tempo em segundos" << endl;
        cin >> dataTimer;
        return dataTimer;
    }
    int transformSecondsHours(int dataTimer)
    {
        int result;
        hours = floor(dataTimer / 3600);
        minutes = floor((dataTimer - (hours * 3600))/60);
        seconds = floor(dataTimer - (hours * 3600 + minutes * 60));        
    }
};

int main()
{
    Timer time;
    time.ReceiveTimeSeconds();
    time.transformSecondsHours(time.dataTimer);
    cout << time.hours <<":"<< time.minutes << ":" << time.seconds << endl;
    return 0;
}