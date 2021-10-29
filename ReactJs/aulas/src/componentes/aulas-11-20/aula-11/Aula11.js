import React, {useState} from 'react'
//CSS
import './Aula11.css'
//Imgs
import LedVerde from '../../imgs/ledVerde.png'
import LedVermelho from '../../imgs/ledVermelho.png'

export default function Aula11(){

    const [ligado, setLigar]=useState(false)
    const cancelar = (obj) => {
        return obj.preventDefault();
    }

    return (
        <>
            <h3> Aula 11 </h3>
            <p>Aula de Eventos com react</p>
            <img className={ligado?'ligado leds':'desligado leds'} 
                 src={ligado?LedVerde:LedVermelho}
                 alt={ligado?'Semaforo Verde':'Semaforo Vermelho'}
            />
            <button onClick={()=>setLigar(!ligado)}>
                    {ligado?'Desligar':'Ligar'}
            </button>
            <p>Cancelando o comportamento padrão de um elemento no react que no caso é o clique</p>
            <a href='https://www.youtube.com/cfbcursos' onClick={(e)=>cancelar(e)}
            
            >Clique aqui</a>
            {/* o elemento e pega o componente que no caso é a ancora */}
        </>
    )
}