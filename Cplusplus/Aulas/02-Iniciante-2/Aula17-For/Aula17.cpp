#include <iostream>
using namespace std;
int main ()
{   
    /* 
        for(inicial ; condicional; controle) { comandos para repetir}
    */
    int x ,y ,z;
    for (x = 0; x < 10 ; x++)
    {
        cout << "O valor de x: " << x << endl;
    }
    // podemos inicializar 2 variaveis e comandar 2 variaveis ou mais
    for (   x =0 , y = 1, z = 2;        // inicializando a variavel
            (x <= 10 && y <= 15) && (z <= 20); // podemos definir varios controles
            x++, y += 2, z += 3)        // podemos incrementar valores diferentes
    {
        cout << "O valor de x: " << x << endl;
        cout << "O valor de y: " << y << endl;
        cout << "O valor de z: " << z << endl;
    }

    return 0;
}