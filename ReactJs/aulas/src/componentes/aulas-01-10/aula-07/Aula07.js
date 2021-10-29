import React from "react";
import DadosFunction from "./props/DadosFunction"

export default function Aula07(){
    const canal = " CFB Cursos"
    const site = " https://youtube.com/cfbcursos"    
    const curso = " Curso React"
    const retornaString = () => {
        return 'Retorno da aula 7'
    }
    const somar = (v1,v2) => {
        return v1 + v2;        
    }

    return (
        <>
            <h3>A aula 07</h3>
            <p> A aula sobre retorno de função usando o props </p>
            < DadosFunction
                canal = {canal}
                site = {site}
                curso = {curso}
                funcao = {retornaString}
                somaFuncao = {somar}
            />
        </>
    )
}