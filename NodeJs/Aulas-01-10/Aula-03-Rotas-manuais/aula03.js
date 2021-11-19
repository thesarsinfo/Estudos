const http = require('http');
const porta = 3000;
const host = '127.0.0.1'

const servidor = http.createServer((request, response) => {
    response.writeHead(200,{'Content-Type':'text/html'});
    if (request.url === '/'){
        response.write('<h1>Seja bem vindo</h1>');        
    }
    else if (request.url === '/canal') {
        response.write('<h1>Saraiva estudos</h1>');
    }
    else if (request.url === '/curso') {
        response.write('<h1>Curso de node</h1>');
    }
    else {
        response.write('<h1>Rota não encontrada</h1>');
    }
    response.end();
})
servidor.listen(porta,host,() => {console.log('Servidor rodando')});