import React from "react";

export default function Numero(props){
    
    return (
        <>
            <p>O valor do state no outro componente estado atual: {props.num}</p>
            <button onClick={() => props.setNum(props.num +10)}>Num com state</button>
        </>
    )
}