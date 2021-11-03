import React,{useEffect,useState} from "react";

export default function Aula19(){

    const [contagem,setContagem]=useState(0)
    /*
    useEffect(
        () => {
            console.log('Pagina Carregada');
            document.title = "Contagem:" + contagem
        }
    )
    */
    return (
        <>
            <h3>Aula 19</h3>
            <p>Trabalhar com hook effect</p>   
            <p>O use effect é chamado toda vez que o componente é carregado</p> 
            <p>Contagem:{contagem}</p>
            <button onClick={() => setContagem(contagem + 1)}>Contar</button>

        </>
    )
}