#include <iostream>
#include <iomanip>
#include <stdio.h>

using namespace std;

double CaptureGoodsPrices( double captureGoodPrices[6]);
double CalculateFinalPrice(double captureGoodPrices[6]);


int main()
{   
    double captureGoodPrices[6]; 
    CaptureGoodsPrices( captureGoodPrices);
    CalculateFinalPrice(captureGoodPrices);
    
    return 0;
}
double CaptureGoodsPrices( double captureGoodPrices[6])
{
    int productCode , quantityProducts;
    float priceProduct;
    
    for (int i = 0; i < 2; i++)
    {
        cout << "Digite o codigo, quantidade e o preco da peca" << endl;
        scanf("%d %d %f", &productCode,&quantityProducts, &priceProduct);
        captureGoodPrices[i] = productCode;
        captureGoodPrices[i + 2] = quantityProducts;
        captureGoodPrices[i + 4] = priceProduct;
        
    }    
    return captureGoodPrices[6];
    
}
double CalculateFinalPrice(double captureGoodPrices[6])
{
    double finalPrice;
    for (int i = 0; i < 2; i++)
    {
        finalPrice += captureGoodPrices[i + 2] * captureGoodPrices[i + 4];
    }
    cout << "VALOR A PAGAR: R$ " << fixed << setprecision(2) <<finalPrice << endl;
}