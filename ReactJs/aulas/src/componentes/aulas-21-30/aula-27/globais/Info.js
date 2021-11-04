import React from "react";
import Globais from "./Globais";

export default function Info(){
    /*Instruções
    Nunca esqueça de importar o modulo ou classe e se um componente atualizar
    não esqueça de utilizar props e state
    */
    return (
        <>            
            <p>{'Canal:' + Globais.canal}</p>
            <p>{'Curso:' + Globais.curso}</p>
            <p>{'Ano:' + Globais.ano}</p>
            <hr/>           

        </>
    )
}