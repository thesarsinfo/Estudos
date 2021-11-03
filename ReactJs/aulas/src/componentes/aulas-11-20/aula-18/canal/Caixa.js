import React from "react";

export default function Caixa(props){

    return (
        <>              
            <p>{props.site}</p>   
            Imprimindo o elemento 0  {props.children[0]} 
            Imprimindo o elemento 1  {props.children[1]} 
            Imprimindo o elemento 2 {props.children[2]} 
            Imprimindo o elemento 3 {props.children[3]} 
            Imprimindo o elemento do Componente Canal {props.children[4]} 
            Imprimindo todos elementos {props.children}            
        </>
    )
}