import React,{useState} from "react";

export default function Aula12(){

    const [logado,setLogar]=useState(false)

    const cumprimento = () => {
        const hora = new Date().getHours();
        console.log(hora);
        if (hora >= 6 && hora <= 12){
            return 'Bom Dia'
        }
        else if (hora > 12 && hora <= 17) {
            return 'Boa Tarde'
        }
        else {
            return 'Boa Noite'
        }
    }

    return (
        <>
            <h3> Aula 12 </h3>
            <p>Redenrização de componentes ou variaveis usando condicional</p>
            <button onClick={()=>setLogar(!logado)}>{logado?'Deslogar':'Logar'}</button>
            <p>{logado?cumprimento():''}</p>
        </>
    )
}