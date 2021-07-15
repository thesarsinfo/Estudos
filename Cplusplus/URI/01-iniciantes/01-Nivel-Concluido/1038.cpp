#include <iostream>
#include <iomanip>

using namespace std;

struct Produts
{
    double products[5] = {4.00,4.50,5.00,2.00,1.50};
    int codigo, quantidade;

    void InsertOrder()
    {
        cout << "Digite o codigo e a quantidade do pedido: " << endl;
        cin >> codigo >> quantidade;        
    }
    double CalculateOrderPrice(int codigo, int quantidade)
    {
        double orderPrice;        
        orderPrice = products[codigo - 1] * quantidade;
        return orderPrice;
    }    
};

int main()
{
    double orderPrice;
    Produts products;
    products.InsertOrder();
    orderPrice = products.CalculateOrderPrice(products.codigo,products.quantidade);
    cout << "Total: R$ " << fixed << setprecision(2) << orderPrice << endl;   
    return 0;
}