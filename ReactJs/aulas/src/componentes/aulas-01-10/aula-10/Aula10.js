
import React,{useState} from "react";
import Numero from "./state/Numero";

export default function Aula10(){

    
    const [num,setarNum]=useState(10);
    let n1 = 10;
    
    return (
        <>
            <h3> Aula 10 </h3>
            <p> Uso do primeiro rook de react o state</p>
            <p>O valor de n1 sem uso de state: {n1}</p>
            <p>O valor do state no estado atual: {num}</p>
            <button onClick={()=>setarNum( n1 + 10)}>N1 sem state</button>
            <button onClick={()=>setarNum(num + 10)}>Num com state</button>
            <p>Usando state em outro componente separado</p>    
            <Numero
                num = {num}
                setNum = {setarNum}
            />        

        </>
    )
}