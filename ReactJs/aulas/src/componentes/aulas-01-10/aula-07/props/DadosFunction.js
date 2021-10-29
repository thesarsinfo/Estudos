import React from "react";

export default function DadosFunction(props){
    const n1 = 10;
    const n2 = 20;
    return (
        <>
            <p> Canal:{props.canal}</p>
            <p> Site:{props.site}</p>
            <p> Curso:{props.curso} </p>
            <p> Retorno função: {props.funcao()}</p>
            <p> {'A soma de ' + n1 + ' com o ' + n2 + ' é igual a ' + props.somaFuncao(n1,n2)}</p>
        </>
    )
}