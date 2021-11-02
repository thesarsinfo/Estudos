import React from "react";

export default function DesafioNota(props){

    return (
        <>
            <label>Digite a nota {props.num}  </label>            
            <input type='text' 
            name={props.nome}
            value={props.nota}
            onChange={(e) => props.change(e)}            
            />
            {/*Passando o componente "e" * */}
            <p></p>
        </>
    )
}
