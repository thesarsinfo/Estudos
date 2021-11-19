const express = require('express');
const rotas = express.Router()

let cursosInfo = [
    {'curso':'node','info':'Curso de Node'},
    {'curso':'react','info':'Curso de react'},
    {'curso':'java','info':'Curso de java'},
    {'curso':'arduino','info':'Curso de arduino'}   
]

rotas.get('/', (request , response) => {
    response.json({Ola:'Seja bem vindo'});
    
})
rotas.get('/:cursoid', (request , response) => {
    const curso = request.params.cursoid
    let cursoInfomacao = cursosInfo.find(i => i.curso === curso)
    if(!cursoInfomacao) {
        response.status(404).json(
            {error:'Curso não encontrado', cursoPesquisado:curso}
        )
    }
    else {
        response.status(200).json(cursoInfomacao)
    }
})

module.exports = rotas


