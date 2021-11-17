import React,{useState, useEffect} from "react";


export default function ListaCarros41(){

    const [carros,setCarros]=useState([])

    useEffect (() => {

        fetch('https://apicfbcursosexemplo1.thiagosaraiva1.repl.co')
            .then(resultado => resultado.json())
            .then(
                (resultado)=>{
                    setCarros(resultado)
                }
            )
    })

    return (
        <div>
            
            {carros.map(
                carro => <div key={carro.id}>{carro.id} -{carro.marca} - {carro.modelo}</div>
            )}
        </div>
    )
}
