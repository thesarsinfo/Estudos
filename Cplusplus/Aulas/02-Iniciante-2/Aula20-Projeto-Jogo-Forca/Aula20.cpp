#include <iostream>
#include <string>

using namespace std;

int main()
{
    string word, storeLetter, shootLetter;     
    const int letterMaxNumbers = 50;
    int letterNumbers, tryNumber = 4, rightShoot , winnerVerify;

    cout << "Digite uma palavra" << endl;
    cin >> word;
    letterNumbers = word.size();
    //Apagar a linha de baixo;
    cout << word << endl;

    string letter[letterMaxNumbers]; 
    string correctWord[letterMaxNumbers];

    for (int i = 0; i < letterNumbers ; i++)
    {         
        letter[i] = storeLetter.append(word, i , 1);
        correctWord[i] = " _ ";
        storeLetter = "";       
        cout << letter[i] << endl;
    }
    
    cout << "A palavra possui: "<< letterNumbers << " letras!" << endl;
    while (tryNumber > 0)
    {
        rightShoot = 0;
        for (int i = 0; i < letterNumbers; i++)
        {
            cout << correctWord[i];
        }
        
        cout << endl << endl << "Digite uma letra" << endl;
        cin >> shootLetter;
        for ( int i = 0; i < letterNumbers; i++)
        {
            if (shootLetter == letter[i])
            {
                correctWord[i] = " " + shootLetter + " ";
                 rightShoot += 1;
            }
            (shootLetter == letter[i]) ? : rightShoot += 0;            
        }
        if (rightShoot == 0 )
        {
            cout << "letra errada" << endl;
            tryNumber--;
            cout << "Voce tem apenas " << tryNumber << " tentativas!!" << endl;
        } else
        {
            cout << "Voce acertou!!!!" << endl;
        }
        winnerVerify = 0;
        for (int i = 0 ; i < letterNumbers; i++)
        {
            if (correctWord[i] != " _ ")
            {
                winnerVerify += 1;
            }
        }
        if (winnerVerify == letterNumbers)
        {
            cout << "Parabens voce ganhou!!!" << endl;
            break;
        }
    }
    return 0;
}