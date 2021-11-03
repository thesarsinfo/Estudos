import React,{useState} from "react";

export default function Aula20(){

    //localStorage.setItem("nome","Saraiva");
    //localStorage.getItem("nome");
    //localStorage.removeItem("nome");

    const [nome,setNome]=useState()

    const armazenar =(chave, valor) => {
        localStorage.setItem(chave,valor)
    }
    const consultar = (chave) => {
        alert(localStorage.getItem(chave));
    }
    const apagar = (chave) => {
        localStorage.removeItem(chave);
        alert("Itens apagados");
    }

    return (
        <>
            <h3>Aula 20</h3>
            <p>Trabalhar com local storage</p>
            <p>Guardar, recuperar e apagar as modificações</p>

            <label>Digite o seu nome</label> <br/>
            <input type="text" name="fNome" value={nome} 
             onChange={(e) => setNome(e.target.value)}></input> <br/>
            <button onClick={()=>armazenar('ls_nome',nome)} >Gravar Nome</button>
            <button onClick={()=>consultar('ls_nome')} >Consultar Nome</button>
            <button onClick={()=>apagar('ls_nome')} >Apagar Nome</button>
        </>
    )
}