#include<iostream>
using namespace std;

int main()
{
    /* 
    São array de varias dimensões ou vetor de vetores
               L  C
    int matriz[3][4];
            0   1   2   3
        0   5
        1           6
        2       7
        
        matriz[0][0] = 5
        matriz[1][2] = 6
        matriz[2][1] = 7
    */

   int matriz[3][4];
   int l,c;
   for(l = 0; l < 3; l++ ) 
    {
        for (c = 0; c < 4; c++)
        {   
            cin >> matriz[l][c] ;
            cout << matriz[l][c] << "  ";
        }
        cout << endl;
    }
    /*
   matriz[0][0] = 0;
   matriz[0][1] = 0;
   matriz[0][2] = 0;
   matriz[0][3] = 0;
   
   matriz[1][0] = 1;
   matriz[1][1] = 1;
   matriz[1][2] = 1;
   matriz[1][3] = 1;

   matriz[2][0] = 2;
   matriz[2][1] = 2;
   matriz[2][2] = 2;
   matriz[2][3] = 2;
    */
   //Para pecorrer usamos o for aninhado
    for(l = 0; l < 3; l++ ) 
    {
        for (c = 0; c < 4; c++)
        {
            cout << matriz[l][c] << "  ";
        }
        cout << endl;
    }

    return 0;
}