#include <iostream>
#include <cstdlib>

using namespace std;
int ReceiveNumbers(int numbers[3]);
int VerifyMaxNumber(int numbers[3]);

int main()
{
    int numbers[3];
    ReceiveNumbers(numbers);
    VerifyMaxNumber(numbers);
    return 0;
}

int ReceiveNumbers(int numbers[])
{
    int OneNumber, TwoNumber, ThreeNumber;
    cout << "Digite os numeros." << endl;
    cin >> OneNumber >> TwoNumber >> ThreeNumber;
    numbers[0] = OneNumber;
    numbers[1] = TwoNumber;
    numbers[2] = ThreeNumber;   
    return numbers[3];
}

int VerifyMaxNumber(int numbers[3])
{
    int maxValue = numbers[0];      
    for (int i = 0; i <= ( sizeof(numbers)/ sizeof(numbers[0] )) ; i++)
    {
        maxValue = (maxValue + numbers[i + 1]+ abs(maxValue - numbers[i + 1])) / 2;

    }
    cout << maxValue << " eh o maior" << endl;    
}