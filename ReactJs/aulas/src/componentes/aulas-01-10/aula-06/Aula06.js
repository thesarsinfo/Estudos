import React from "react";
import Dados from "./data/Dados";

export default function Aula06(){
    const canal = " CFB Cursos"
    const site = " https://youtube.com/cfbcursos"    
    const curso = "ReactJs"
    
    return(
        <>
            <h3>Aula 6 - Trabalhando com props  </h3>
            <Dados
                canal={canal}
                site={site}
                Curso={curso}
            />
        </>
    )
}