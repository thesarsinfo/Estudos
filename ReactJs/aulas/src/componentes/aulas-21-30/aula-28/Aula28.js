import React,{useState,useEffect} from "react";
import Pagina1 from "./paginas/Pagina1";
import Pagina2 from "./paginas/Pagina2";

export default function Aula28(){

    const [pagina, setPagina]=useState(0);

    useEffect(
        () => {
            const url=window.location.href;
            const res = url.split('?');
            setPagina(res[1]);
        }
    )

    const LinksPaginas = (n) => {
        if (n === 1){
            window.open("http://localhost:3000?1", '_self')
        }
        else if (n === 2){
            window.open("http://localhost:3000?2", '_self')
        }
    }

    const retornarPagina = () => {
        if(pagina === 1){
            return <Pagina1/>
        }
        else if (pagina === 2){
            return <Pagina2/>
        }
        else{
            return (
            <>
                <button onClick={()=> LinksPaginas(1)}>Página 1</button>
                <button onClick={()=> LinksPaginas(2)}>Página 2</button>
            </>
            )
        }

    }

    return (
        <>
            <h3>Aula 28</h3>
            <p>Navegando entre telas de forma nativa em React</p>
            {retornarPagina()}
        </>
    )
}