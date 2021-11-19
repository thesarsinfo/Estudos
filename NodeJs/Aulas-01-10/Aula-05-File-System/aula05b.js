//trabalhando com appendfile
const http = require('http')
const fs = require('fs')
const porta = process.env.PORT

const server = http.createServer((req, res) => {
    //podemos usar o openFile que funciona do mesmo jeito
    fs.appendFile('teste.txt','Curso de node - Saraiva Estudos', (err) => {
        if(err)throw err
        {
            console.log('Arquivo criado')
        }        
        res.end()
    })
})

server.listen(porta || 3000, () => {console.log('Server aula 05 rodando')})