
const http = require('http');
const port = process.env.PORT

const servidor = http.createServer((request,response) => {
    const protocol = response.statusCode = 200
    response.writeHead(protocol,{'Content-Type':'text/plain'})
    response.end('Curso saraiva estudos')
})

servidor.listen(port || 3000, () => {console.log('Servidor aula 04 rodando')});