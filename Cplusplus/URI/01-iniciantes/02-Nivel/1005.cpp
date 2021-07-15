#include <iostream>
#include <iomanip>
 
using namespace std;
 
int main()
{
    double firstGrade, secondGrade , averageGrade;

    
    cout << "Digite a primeira nota: " << endl;
    cin  >> firstGrade;
    cout << "Digite a segunda nota: " << endl;
    cin  >> secondGrade; 
    averageGrade = ((firstGrade * 3.5) + (secondGrade * 7.5))/ 11.0;
    cout << "MEDIA = " << fixed << setprecision(5) << averageGrade << endl;   
 
    return 0;
}