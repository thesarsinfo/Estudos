import React from "react"

export default function Dados(props){

    return (
        <>
            <p> Canal:{props.canal}</p>
            <p> Site:{props.site}</p>
            <p> Curso:{props.curso} </p>            
        </>
    )
}