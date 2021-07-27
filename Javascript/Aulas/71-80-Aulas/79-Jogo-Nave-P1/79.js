let direcaoYJogador, direcaoXJogador
function teclaDown()
{
    let tecla = event.keyCode;
    if (tecla == 37) //esquerda
    {
        direcaoXJogador = -1
    }
    else if (tecla == 39) //direita
    {
        direcaoXJogador = 1
    }
    if (tecla == 38) //cima
    {
        direcaoYJogador = -1
    }    
    else if (tecla == 40) //baixo
    {
        direcaoYJogador = 1
    }
    if (tecla == 32)//espaço // tiro
    {
        //função tiro
    }
}
function teclaUp()
{
    let tecla = event.keyCode;
    if (tecla == 38 || 40) //esquerda
    {
        direcaoYJogador = 0
    }
    else if (tecla == 37 || 39) //direita
    {
        direcaoXJogador = 0
    }   
}
