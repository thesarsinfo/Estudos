#include <iostream>
#include <iomanip>
 
using namespace std;
 
int main() 
{
 
    double firstGrade, secondGrade , thirdGrade , averageGrade;

    
    cout << "Digite a primeira nota: " << endl;
    cin  >> firstGrade;
    cout << "Digite a segunda nota: " << endl;
    cin  >> secondGrade; 
    cout << "Digite a terceira nota: " << endl;
    cin  >> thirdGrade; 
    averageGrade = ((firstGrade * 2) + (secondGrade * 3) + (thirdGrade * 5))/ 10.0;
    cout << "MEDIA = " << fixed << setprecision(1) << averageGrade << endl;  
}