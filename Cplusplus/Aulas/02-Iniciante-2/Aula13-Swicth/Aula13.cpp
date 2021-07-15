#include <iostream> //biblioteca para comandos basicos de terminal

using namespace std; //dentro da biblioteca iostream usamos o standart

int main()
{
    // Aula 13 / Switch case
    //somente expressões de igualdade e não pode ter duas constantes.
    cout << "Aula 13" << endl;
    // Comando padrão
    // switch (expressião)
    // {
    // case /* constant-expression */:
    //     /* code */
    //     break;
     
    // default:
    //     break;
    // }
    int val;
    cout << "Digite um valor" << endl;
    cout << "[1] para verde , [2]= azul, [3]=vermelho" << endl;
    cin >> val;

    switch (val)
    {
        case 1:
            cout << "Cor selecionada: Verde " << endl; 
            break;
        case 2:
            cout << "Cor selecionada: Azul" << endl;
            break;
        case 3:
            cout << "Cor selecionada: Vermelho " << endl;
            break;    
        default:
            cout << "Valor selecionado invalido" << endl;
        break;
    }
    cout << "Exercicio 2" << endl;

    cout << "Digite um valor" << endl;
    cout << "[1,2,3] para verde , [4,5,6]= azul "<< endl;
    cin >> val;

    switch (val)
    {
        case 1:
        case 2:
        case 3:
            cout << "Cor selecionada: Verde " << endl; 
            break;
        case 4:
        case 5:
        case 6:
            cout << "Cor selecionada: Azul" << endl;
            break;         
        default:
            cout << "Valor selecionado invalido" << endl;
        break;
    }
    cout << "Exercicio 2 finalizado" << endl;
    cout << "Switch aninhado" << endl;
     cout << "Digite um valor" << endl;
    cout << "[1]=Carro, [2]= Moto, [3]=Aviao, [4]=helicoptero" << endl;
    cin >> val;

    switch (val)
    {
        case 1:
        case 2:        
            cout << "Transporte Terreste " << endl; 
            switch (val)
            {
                case 1:
                    cout << "Carro Selecionado " << endl; 
                break;
                case 2:
                    cout << "Moto Selecionado " << endl; 
                break;       
            }
        break;
        case 3:
        case 4:    
            cout << "Transporte Aereo" << endl;
            switch (val)
            {
                case 3:
                    cout << "Aviao Selecionado " << endl; 
                break;
                case 4:
                    cout << "Helipcotero Selecionado " << endl; 
                break;       
            }
        break;         
    default:
        cout << "Valor selecionado invalido" << endl;
    break;
    }
    

    system("pause");
    return 0;
}