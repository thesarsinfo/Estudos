import React from "react";
import Dados from "./Dados";

export default function Corpo()
{
    const canaliza=()=>{
        return "Saraiva Estudos aula 7"
    }  
    const cursera = 'Curso de React'
    const yout = 'youtube.com/cfbcursos'

    const somar = (v1 , v2) => {
        return v1 + v2
    }
    return(
        <section>
            <h2>Componente corpo</h2>
            <p>Curso de React </p>
            <p>Muito treino para obter resultado</p>
            <p>Aula 6 testando componente dados</p>
            <Dados
                 canal= {canaliza}
                 youtube={yout}
                 curso={cursera}
                 somar={somar}
            />
        </section>
    )
}