import React,{useState} from "react";

const tabelaImc = () => {
    return (
        <table border='1' style={{borderCollapse:'collapse'}}>
            <thead>
                <tr>
                    <th>
                        Classificação
                    </th>
                    <th>
                        IMC
                    </th>
                </tr>

            </thead>
            <tbody>
                <tr>
                    <td>Abaixo do Peso</td>
                    <td>Abaixo do 18,5</td>
                </tr>
                <tr>
                    <td>Peso Normal</td>
                    <td>Entre 18,5 e 24,9</td>
                </tr>
                <tr>
                    <td>Sobrepeso</td>
                    <td>Entre 25 e 29,9</td>
                </tr>
                <tr>
                    <td>Obesidade</td>
                    <td>Entre 30 e 34,9</td>
                </tr>
                <tr>
                    <td>Obesidade Grau II</td>
                    <td>Entre 35 e 39,9</td>
                </tr>
                <tr>
                    <td>Obesidade Morbida</td>
                    <td>Maior de 40</td>
                </tr>
            </tbody>
        </table>
    )
}

const formPeso = (peso , setPeso) => {
    return (
        <div>
            <label style={{paddingLeft:'10px'}}>Peso: </label>
                <input type="text" value={peso} onChange={(e) => {setPeso(e.target.value)}}/>
            
        </div>
    )
}
const formAltura = (altura , setAltura) => {
    return (
        <div>
            <label style={{paddingLeft:'1px'}}>Altura: </label>
            <input type="text" value={altura} onChange={(e) => {setAltura(e.target.value)}}/>
        </div>
    )
}
const formCalcular = (peso, altura, setResultado) => {
    
    const calcular = () => {
       setResultado(peso / (altura * altura))    
    }
    return (
        <div>
            <button onClick={calcular} > Calcular</button>
        </div>       
    )
}

const formResultado = (resultado) => {
    return (
        <div>
            <p> Resultado: {resultado.toFixed(2)}</p>
        </div>
    )
}

export default function Aula30(){

    const [peso, setPeso]=useState(0);
    const [altura, setAltura]=useState(0);
    const [resultado, setResultado]=useState(0);


    return (
        <>
            <h3>Aula 30</h3>
            <p>Calculadora de IMC</p>
            {formPeso(peso,setPeso)}
            {formAltura(altura,setAltura)}
            {formResultado(resultado)}
            {formCalcular(peso,altura,setResultado)}
            {tabelaImc()}

        </>
    )
}