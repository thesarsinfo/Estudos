let painel, btnBack, btnForward , btnBackDois
function hisBack()
{
    window.history.back()
}
function hisForward()
{
    window.history.forward()
}
function hisGo(val) // permite avançar ou voltar nx no historico
{
    //back 2x
    window.history.go(val); //Parametro negativo voltar Parametro positivo avança
    
}

function inicia()
{
    btnBack = document.getElementById("btnBack");
    btnForward = document.getElementById("btnForward");
    btnBackDois = document.getElementById("btnBackDois");

    btnBack.addEventListener("click", () => {hisGo(-1)})
    btnForward.addEventListener("click",() => {hisGo(1)})
    btnBackDois.addEventListener("click",() => {hisGo(-2)})

    painel = document.getElementById("info");
    //Pega o numero de links navegados pelo usuario
    painel.innerHTML += history.length;
}
window.addEventListener("load",inicia);