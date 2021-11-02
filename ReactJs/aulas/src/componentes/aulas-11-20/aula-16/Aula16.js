import React,{useState} from "react";
import Nota from "./nota/Nota";
import Resultado from "./nota/Resultado";

export default function Aula16(){

    const [nota1, setarNota1] = useState(0)
    const [nota2, setarNota2] = useState(0)
    const [nota3, setarNota3] = useState(0)
    const [nota4, setarNota4] = useState(0)
    return (
        <>
            <h3>Aula 16</h3>
            <p>Elevação de State</p>
            <Nota num={1} nota={nota1} setNota={setarNota1}/>
            <Nota num={2} nota={nota2} setNota={setarNota2}/>
            <Nota num={3} nota={nota3} setNota={setarNota3}/>
            <Nota num={4} nota={nota4} setNota={setarNota4}/>
            <Resultado somaNotas={parseFloat(nota1)  + parseFloat(nota2) +
                     parseFloat(nota3) + parseFloat(nota4)}/>
        </>
    )
}