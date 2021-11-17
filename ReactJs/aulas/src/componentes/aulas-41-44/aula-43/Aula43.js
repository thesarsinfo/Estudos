import React from "react";

function ListaNumeros(props){
    const num = props.numeros
    const listaNumerosMap = num.map(
        (n) => <li key={n.toString()} /** key trabalha com string*/>{n}</li>
        
    )
    return (<ul>{listaNumerosMap}</ul>)
}

const arrayNumeros = [1,2,3,4,5,6,7,8,9]

export default function Aula43(){

    return (
        <>
            <ListaNumeros numeros={arrayNumeros}/>
        </>
    )
}