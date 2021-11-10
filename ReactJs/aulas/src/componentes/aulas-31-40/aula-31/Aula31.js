import React, { useState } from "react";
import CalcularInputs from "./componentes/CalcularInputs";
//Componentes
import Inputs from "./componentes/Inputs";
import ResultadoButton from "./componentes/ResultadoButton";
import TabelaIMC from "./componentes/TabelaIMC"

const verificarInputsF = (e,entrada,setarEntrada) => {
    if(e.target.getAttribute('name') === 'peso'){
        setarEntrada({'peso':e.target.value,'altura': entrada.altura})

    }
    else if(e.target.getAttribute('name') === 'altura'){
        setarEntrada({'peso':entrada.peso,'altura': e.target.value})  

    }
}


export default function Aula31(){
    const [entrada,setarEntrada] = useState({'peso':0,'altura':0})
    const [resultadoConta,setarResultado] = useState(0)

    return (
        <>
            <h3>Aula 31 e 32 Desafio IMC componentizado</h3>
            <p>Calculadora de IMC</p>
            <label>
                Peso: 
                <Inputs
                    name={'peso'}
                    dados={entrada.peso}
                    dadosMudados={(e)=>verificarInputsF(e,entrada,setarEntrada)}
                />
            </label>
            <label>
                Altura:
                <Inputs
                    name={'altura'}
                    dados={entrada.altura}
                    dadosMudados={(e)=>verificarInputsF(e,entrada,setarEntrada)}
                />
            </label>
            <label>Resultado:</label>
            <CalcularInputs
                resultado={resultadoConta}
            />
            <ResultadoButton
            entPeso={entrada.peso}
            entAlt={entrada.altura}
            setarResultado={setarResultado}                     
            />
            <TabelaIMC/>
        </>
    )
}