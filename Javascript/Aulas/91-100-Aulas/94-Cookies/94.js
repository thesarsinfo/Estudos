
criarCookie = (nomeCookie, valor, expira) =>
{
    //se não colocar data o cookie é deletado depois que sair do site ou fechar o navegador
    let dataExpira = "expires =" + expira;
    document.cookie = nomeCookie + "=" + valor + "; " + dataExpira
}
//Funçao para pesquisar o cookie dentro do navegador do usuario e retorna seu valores
lerCookie = (nomeCookie) =>
{
    let vNome = nomeCookie + "=";
    //Buscando todos os cookies da paginas em um array separados por ;
    let carregaTodosCookies = document.cookie.split(';');
    
    for (let i = 0; i < carregaTodosCookies.length;i++)
    {
        let cookieVerifica = carregaTodosCookies[i];
        console.log(cookieVerifica);
        //Eliminar espaços em brancos
        while (cookieVerifica.charAt(0) == ' ')
        {
            cookieVerifica = cookieVerifica.substring(1);
        } 
        if (cookieVerifica.indexOf(vNome) == 0) 
        return cookieVerifica.substring(vNome.length, cookieVerifica.length)
    }
    return "";
}
VerificaCookie = () => 
{
    let username = lerCookie("username");
    if (username != "")
    {
        alert("Bem vindo novamente " + username);
    }
    else
    {
        username = prompt("Digite seu nome: ", "");
        if(username != "" && username != null)
        {
            criarCookie("username",username, " Tue, 01 Jan 2115 12:00:00 UTC " );
        }  
    }
}
window.addEventListener("load",VerificaCookie);