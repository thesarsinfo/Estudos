let aux = location.hash //captura o dados da URL
//dividindo os nomes
let dados = aux.split("#")
document.write(dados);
document.write("<hr>");
document.write(dados[1]); //0 é uma vigurla
document.write("<br>");
document.write("<hr>");
//Pega o endereço da pagina
let varHostname = location.hostname; //127.0.0.1 pq estamos usando live server
document.write(varHostname);
document.write("<hr>");
//Url Completa
let varHref = location.href; //Obtem o endereço da pagina Url Completa
document.write(varHref);
document.write("<hr>");
//Definir o valor da Url

/*varHref = location.href = /* "https://www.youtube.com/cfbcursos";
Nesse caso acima a página é redirecionada ao endereço ao carregar
Muito util se sua página trocou de endereço*/
/*document.write(varHref);
document.write("<hr>");*/

//Origin = Mostra o Protocolo + hostname, numero de porta
let varOrigin = location.origin;
document.write("Origin: " + varOrigin);
document.write("<hr>");
//Pathname
let varPathname = location.pathname;
document.write("Pathname: " + varPathname); //mostra de /javascript/...
document.write("<hr>");
//Port
let varPort = location.protocol;
document.write("Protocolo: " + varPort); //mostra o protocolo do http:
document.write("<hr>");

let aux2 = location.search // busca na url por "?"
let dados2 = aux2.split("?")
document.write(dados2)
dados2 = dados2[1].split("=");
document.write(dados2)
document.write("<hr>");
document.write(dados2[1]); //0 é uma vigurla
document.write("<br>");
document.write("<hr>");