
const express = require('express');
const app = express();
const port = process.env.PORT

app.get('/', (req,res) =>{
    res.send('Seja bem vindo');    
})

app.get('/canal', (req,res) =>{
    res.json({canal:'Saraiva Estudos'});    
})

app.listen(port || 3000, () => {console.log('Servidor aula 04 express rodando')});