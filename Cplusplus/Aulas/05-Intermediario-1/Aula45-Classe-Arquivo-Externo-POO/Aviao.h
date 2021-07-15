#ifndef AVIAO_H_INCLUDED
#define AVIAO_H_INCLUDED
using namespace std;
class Aviao
{    
    public:
        int velAtual = 0;
        int velMax;
        string tipo;
        Aviao(int tipoAviao);//MEtodo prototipo de construtor
        void Imprimir();

    private:

};
Aviao::Aviao(int tipoAviao)//Obs: na variaveis não usamos o this no construtor
{
    if (tipoAviao == 1)
    {
        velMax = 800;
        tipo = "Jato";
    }else if (tipoAviao == 2)
    {
        velMax = 550;
        tipo = "Monomotor";
    }else if (tipoAviao == 3)
    {
        velMax = 370;
        tipo = "Planador";
    }
}
void Aviao::Imprimir()
{
    cout << "Tipo.............: " << tipo << endl;
    cout << "Velocidade Maxima: " << velMax << endl;
    cout << "Velocidade Atual.: " << velAtual << endl;
    cout << "-------------------" << endl;
}

#endif //AVIAO_H_INCLUDED
