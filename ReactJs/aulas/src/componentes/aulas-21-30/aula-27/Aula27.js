import React,{useState} from "react";
import Globais from "./globais/Globais";
import Info from "./globais/Info";

export default function Aula27(){
    /*Instruções
    Nunca esqueça de importar o modulo ou classe e se um componente atualizar
    não esqueça de utilizar props e state
    */
   const [resumo,setResumo]=useState(Globais.resumo)
   const gravarResumo = () => {
       Globais.resumo = resumo;
   }
   const verResumo = () => {
       alert(Globais.resumo)
   }
    return (
        <>
            <h3>Aula 27</h3>
            <p>Utilizando variaveis globais em todo o aplicativo</p>
            <Info/>
            <hr/>
            <p>{'Canal: ' + Globais.canal}</p>
            <p>{'Curso: ' + Globais.curso}</p>
            <p>{'Ano: ' + Globais.ano}</p>
            <hr/>
            <input type="text" value={resumo} size="50"
            onChange={(e) => setResumo(e.target.value)}/> 
            <br/>
            <button onClick={() => gravarResumo()}>Gravar Resumo</button>
            <button onClick={() => verResumo()}>Ver Resumo</button>
        </>
    )
}