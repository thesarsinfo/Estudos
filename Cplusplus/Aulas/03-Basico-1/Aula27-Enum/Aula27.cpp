#include <iostream>

using namespace std;

int main()
{
    /* 
    Enum uma lista para receber valores numericos
                0       1       2       3 valor padrao
    */
   enum armas{ fuzil, revolver, rifle, escopera };
   armas armaSel;
   
   armaSel = fuzil;
   cout << armaSel << endl;
   armaSel = rifle;
   cout << armaSel << endl;
   enum armass{ fuzill = 100, revolverr , riflee, escoperaa };
   armass armaSele;
   armaSele = fuzill; //100
   cout << armaSele << endl;
   armaSele = revolverr; //101 mesmo nao especificado ele imprime o proximo numero do anterior tornando util em 
   //lista longas que basta identificar o primeiro
   cout << armaSele << endl;



    return 0;
}