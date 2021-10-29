import React from "react";
//imgs
import Eu from "./../../imgs/eu.png"

export default function Aula04(){
    const canal = "CFB Cursos"
    const curso = "Curso de React"
    //function
    const retornaString = () => {
        return ' A função retorna essa string completa  curso é muito util '
        + 'feito passo a passo'
    }

    return (
        <section>
            <h3>Aula 4 - Constantes e Variaveis e inserindo imagens</h3>
            <p> {'Usando variavel: ' + canal}</p>
            <p> {'Usando variavel de constante: ' + curso}</p>
            <p>{retornaString()}</p>
            <img src={Eu} alt="eu"/>
        </section>
    )
}