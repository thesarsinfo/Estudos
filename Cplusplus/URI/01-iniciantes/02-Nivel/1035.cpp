#include <iostream>
#include <string>

using namespace std;
struct Selection
{
    int numbers[4];

    void ReceiveNumbers()
    {    
        cout << "Digite os numeros: " << endl; 
        cin >> numbers[0] >> numbers[1] >> numbers[2] >> numbers[3];  
               
    }
    string SelectCases()
    {        
        string response;
        if(numbers[1] > numbers[2])
        {
            if (numbers[3]> numbers[0])
            {
                if (numbers[2] + numbers[3] > numbers[0] + numbers[1])
                {
                    if (numbers[2] > 0 && numbers[3] > 0)
                    {
                        if (numbers[0] %2 == 0)
                        {
                            response = "Valores aceitos";
                        }else
                        {
                            response = "Valores nao aceitos";
                        }
                    }else
                    {
                        response = "Valores nao aceitos";
                    }
                }else
                {
                    response = "Valores nao aceitos";
                }
            }else
            {
                response = "Valores nao aceitos";
            }
        }else
        {
            response = "Valores nao aceitos";
        }
        return response;
    }
};

int main()
{
    string response;
    Selection select;
    select.ReceiveNumbers();    
    response = select.SelectCases();       
    cout << response << endl;
    return 0;
}
