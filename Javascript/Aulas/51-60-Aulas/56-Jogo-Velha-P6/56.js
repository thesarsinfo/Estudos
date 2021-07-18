let jogo = []; /** P*/
let tabuleiro = []; 
let quemJoga = 0;//0 = jogador e 1 = CPU
let verifica; // verifica se houve vencedor ou não
let jogando = true; // false jogo parado
let nivel = 2; // nivel da cpu
let jogadaCpu = 1; //qual 
let quemComeca = 1;
let jogada = 0; //Controla numeros de jogadas

function cpuJoga()
{
    if(jogando)
    {        
        (nivel == 1) ? cpuNivelUm() : cpuNivelDois();             
        atualizaTabuleiro();
        jogada++;
        verifica = verificaVitoria();
        if (verifica != "")
        {
            alert(verifica + " venceu");
            jogando = false;
        }
        quemJoga = 0;
    }
}
function cpuNivelUm()
{
    let l,c;
    do
    {
        l = Math.round(Math.random()*2)
        c = Math.round(Math.random()*2)
    } while(jogo[l][c] != "");
    jogo[l][c]="O";
}

function cpuNivelDois()
{
   
    let tipoAnalise;
    for (let i = 0; i < 2; i++) //Verifica jogada ataque ou defesa
    {
       tipoAnalise = (i == 0) ? "O" : "X"
    //Ataque linha
        for (let l = 0; l < 3; l++)
        {
            if(jogo[l][0]== tipoAnalise && jogo[l][1]== tipoAnalise && jogo[l][2]=="")
            {
                jogo[l][2]="O";
                return          
            } 
            else if (jogo[l][0]==tipoAnalise && jogo[l][2]==tipoAnalise && jogo[l][1]=="")
            {
                jogo[l][1]="O";
                return     
            }       
            else if (jogo[l][1]==tipoAnalise && jogo[l][2]==tipoAnalise && jogo[l][0]=="")
            {
                jogo[l][0]="O";
                return;            
            }     
        }
        //Ataque coluna
        for (let c = 0; c < 3; c++)
        {
            if(jogo[0][c]==tipoAnalise && jogo[1][c]==tipoAnalise&& jogo[2][c]=="")
            {
                jogo[2][c]="O";
                return;            
            } 
            else if(jogo[0][c]== tipoAnalise && jogo[2][c]== tipoAnalise&& jogo[1][c]=="")
            {
                jogo[1][c]="O";
                return;            
            }      
            else if(jogo[1][c]== tipoAnalise  && jogo[2][c]== tipoAnalise && jogo[0][c]=="")
            {
                jogo[0][c]="O";
                return;            
            }
        }
        //Ataque diagonal esquerda
        if(jogo[0][0]== tipoAnalise  && jogo[1][1]== tipoAnalise && jogo[2][2]=="")
        {
            jogo[2][2]="O";
            return;            
        }
        else if(jogo[0][0]== tipoAnalise  && jogo[2][2]== tipoAnalise && jogo[1][1]=="")
        {
            jogo[1][1]="O";
            return;            
        }
        else if(jogo[1][1]== tipoAnalise  && jogo[2][2]== tipoAnalise && jogo[0][0]=="")
        {
            jogo[0][0]="O";
            return;            
        }
        //Diagonal direita
        if(jogo[2][0]== tipoAnalise  && jogo[1][1]== tipoAnalise && jogo[0][2]=="")
        {
            jogo[0][2]="O";
            return;            
        }
        else if(jogo[2][0]== tipoAnalise  && jogo[0][2]== tipoAnalise && jogo[1][1]=="")
        {
            jogo[1][1]="O";
            return;            
        }
        else if(jogo[1][1]== tipoAnalise  && jogo[0][2]== tipoAnalise && jogo[2][0]=="")
        {
            jogo[2][0]="O";
            return;            
        }
    }
    if (jogada < 8)         
    {
        do
        {
            l = Math.round(Math.random()*2)
            c = Math.round(Math.random()*2)
        } while(jogo[l][c] != "");
        jogo[l][c]="O";
    }
    else
    {
        for(let l = 0; l < 3; l++)
        {
            for(let c = 0; c < 3; c++)
            {
                if(jogo[l][c]=="")
                {
                    jogo[l][c]="O";
                }
            }
        }
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
           
            atualizaTabuleiro();
            verifica = verificaVitoria();
            if (verifica != "")
            {
                alert(verifica + " venceu");
                jogando = false;
            }
            jogada++;
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
    jogada = 0;
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
    atualizaTabuleiro();
    quemComeca = (quemComeca ==1)? 0 : 1;
    quemJoga = quemComeca;
    let nomeJogador = (quemJoga == 0)? "Jogador" : "CPU"
    document.getElementById("dvQuemComeca").innerHTML = "Quem Começou: " + nomeJogador;
    (quemJoga == 1)?cpuJoga(): 0;
}

window.addEventListener("load",inicia)