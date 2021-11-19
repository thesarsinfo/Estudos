const express = require('express');
const rotas = require('./rotas/rotas');
const port = process.env.PORT || 3000;
const hostname = '127.0.0.1';
const app = express()

app.use('/', rotas)

app.get('*', (request,response) => {
    response.send('Saraiva Estudos');
})

app.listen(port , hostname, () => {
    console.log('App da aula 07 rodando')
})