import React from "react";

export default function DesafioResultado(props){

    return (
        <>
            <p>A soma das notas é {props.somaNotas}</p>
            <p>{props.somaNotas >= 90   ? 'Aprovado com louvor'
                                        : props.somaNotas >= 50 
                                            ? 'Aprovado'
                                            : 'Reprovado'
                }
            </p>
        </>
    )
}
