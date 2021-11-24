const http = require('http')
const eventos = require('events')
const EventoEmissor = new eventos.EventEmitter()
const port = process.env.PORT || 3000
const hostname = '127.0.0.1'
const retorno = () => {console.log('servidor aula 11 rodando')}

const final = () => {console.log('Fim do processo')}

// nome do evento é uma string e apos virgula é uma funçao
EventoEmissor.on('msg', () => console.log('Curso de node'))
EventoEmissor.on('fim', final)

const servidor = http.createServer((req,res) => {
    // Aqui colocamos o evento que queremos disparar

    EventoEmissor.emit('msg')
    res.writeHead(200,{'Content-Type':'text/plain'})
    res.write('CFB Cursos')
    // Aqui colocamos o evento que queremos disparar
    EventoEmissor.emit('fim')
    res.end()
})

servidor.listen(port,hostname,retorno)