#include <iostream>
#include <string>

using namespace std;
/*
Aula 44 Classes parte 1 Objetos publicos e privados

*/
class Aviao
{    
    public:
        int velAtual = 0;
        int velMax;
        string tipo;
        void Iniciar(int tipoAviao);//Prototipo

    private:

};
//Construindo o metodo do ini da classe aviao.
void Aviao::Iniciar(int tipoAviao)//Tipo 1 = jato, 2 = Monomotor, 3 = Planador
{
    if (tipoAviao == 1)
    {
        this->velMax = 800;
        this->tipo = "Jato";
    }else if (tipoAviao == 2)
    {
        this->velMax = 550;
        this->tipo = "Monomotor";
    }else if (tipoAviao == 3)
    {
        this->velMax = 370;
        this->tipo = "Planador";
    }
}

int main()
{
    //Instaciando a classe usamos a vriavel de ponteiro mais muito parecido com CSharp    
    Aviao *av1 = new Aviao();
    Aviao *av2 = new Aviao();
    av1->Iniciar(3);
    av2->Iniciar(2);
    //usamos uma seta para imprimir a propriedade de avião
    cout << av1->velMax;
    cout << av2->velMax;
    return 0;
}