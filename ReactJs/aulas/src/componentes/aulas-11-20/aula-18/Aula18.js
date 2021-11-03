import React from "react";
import Caixa from "./canal/Caixa";
import Canal from "./canal/Canal";

export default function Aula18(){

    return (
        <>
            <h3>Aula 18</h3>
            <p>Trabalhar com elementos de contenção ou props.children</p>
            <Caixa site="www.cfbcursos.com.br">
                <p>A partir daqui todos são props children</p>
                <p>Lembrando que os elementos são um array </p>
                <h3>Saraiva estudos</h3>
                <p>Cursos de react</p>
                <Canal/>
            </Caixa>
    
        </>
    )
}