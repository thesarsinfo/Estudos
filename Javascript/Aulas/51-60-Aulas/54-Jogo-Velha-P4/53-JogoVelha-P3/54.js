let jogo = []; /** P*/
let tabuleiro = []; 
let quemJoga = 0;//0 = jogador e 1 = CPU
let verifica; // verifica se houve vencedor ou não
let jogando = true; // false jogo parado
let nivel = 1; // nivel da cpu
let jogadaCpu = 1; //qual 
let quemComeca = 1;

function cpuJoga()
{
    if(jogando)
    {
        let l,c;
        if(nivel==1)
        {
            do
            {
                l = Math.round(Math.random()*2)
                c = Math.round(Math.random()*2)
            }while(jogo[l][c] != "");
            jogo[l][c]="O";
            
        } else if(nivel == 2)
        {
            //Rotina Nivel 2
        }
        verifica = verificaVitoria();
        if (verifica != "")
        {
            alert(verifica + " venceu");
            jogando = false;
        }
        atualizaTabuleiro();
        quemJoga = 0;
    }
}
function verificaVitoria()
{
    let l,c;
    //Linhas verificadas
    for(l = 0; l < 3; l++)
    {
        if
        (
            (jogo[l][0] == jogo[l][1]) && (jogo[l][1] == jogo[l][2])
        )
        {
            return jogo[l][0]
        }
    }
    //Verifica Colunas
    for(c = 0; c < 3; c++)
    {
        if
        (
            (jogo[0][c] == jogo[1][c]) && (jogo[1][c] == jogo[2][c])
        )
        {
            return jogo[0][c];
        }
    }
    //verifica Diagonais
    if
    (
        (jogo[0][0] == jogo[1][1]) && (jogo[1][1] == jogo[2][2])
    )
    {
        return jogo[0][0];
    }
    if
    (
        (jogo[0][2] == jogo[1][1]) && (jogo[1][1] == jogo[2][0])
    )
    {
        return jogo[0][2] ;
    }
    return "";
}
function jogar(p) //jogada do jogador
{
    if((jogando)&&(quemJoga==0))
    {
        switch(p)
        {
            case 1:
                if(jogo[0][0] == "")
                {
                    jogo[0][0] = "X"
                    quemJoga = 1;
                }
            break;
            case 2:
                if(jogo[0][1] == "")
                {
                    jogo[0][1] = "X"
                    quemJoga = 1;
                }
            break;
            case 3:
                if(jogo[0][2] == "")
                {
                    jogo[0][2] = "X"
                    quemJoga = 1;
                }
            break;
            case 4:
                if(jogo[1][0] == "")
                {
                    jogo[1][0] = "X"
                    quemJoga = 1;
                }
            break;
            case 5:
                if(jogo[1][1] == "")
                {
                    jogo[1][1] = "X"
                    quemJoga = 1;
                }
            break;
            case 6:
                if(jogo[1][2] == "")
                {
                    jogo[1][2] = "X"
                    quemJoga = 1;
                }
            break;
            case 7:
                if(jogo[2][0] == "")
                {
                    jogo[2][0] = "X"
                    quemJoga = 1;
                }
            break;
            case 8:
                if(jogo[2][1] == "")
                {
                    jogo[2][1] = "X"
                    quemJoga = 1;
                }
            break;
            case 9:
                if(jogo[2][2] == "")
                {
                    jogo[2][2] = "X"
                    quemJoga = 1;
                }
            break;
                
        }
        if (quemJoga ==1)
        {        
            verifica = verificaVitoria();
            if (verifica != "")
            {
                alert(verifica + " venceu");
                jogando = false;
            }
            atualizaTabuleiro();
            cpuJoga();
        }
    }
}
function atualizaTabuleiro()
{
    for(let l=0; l < 3 ; l++ )
    {
        for(let c = 0; c < 3; c++)
        {
            if(jogo[l][c] == "X")
            {
                tabuleiro[l][c].innerHTML = "X";
                tabuleiro[l][c].style.cursor = "default";
            }
            else if(jogo[l][c] == "O")
            {
                tabuleiro[l][c].innerHTML = "O";
                tabuleiro[l][c].style.cursor = "default";
            }
            else //limpa o jogo
            {
                tabuleiro[l][c].innerHTML = "";
                tabuleiro[l][c].style.cursor = "pointer";
            }
        }
    }
}
function inicia()
{
    jogando = true;
    jogadaCpu = 1;
    jogo=
    [
        ["","",""], //3 linhas com 3 colunas
        ["","",""],
        ["","",""]
    ];
    tabuleiro = 
    [
        [document.getElementById("p1"),document.getElementById("p2"),document.getElementById("p3")],
        [document.getElementById("p4"),document.getElementById("p5"),document.getElementById("p6")],
        [document.getElementById("p7"),document.getElementById("p8"),document.getElementById("p9")]
    ];
}

window.addEventListener("load",inicia)