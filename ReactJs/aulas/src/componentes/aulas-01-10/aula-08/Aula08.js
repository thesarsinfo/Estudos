import React from "react";
//CSS
import "./Aula08.css"

export default function Aula08(){

    const color = {
        color: '#00f',
        fontSize: '16px',
        fontFamily: 'Arial'
    }

    return (
        <>
            <section>
                <h3>Aula 08</h3>
                <p> Formas de usar CSS no react</p>
                <p style={{color: '#f00',fontSize: '25px'}}> CSS inline não recomendado</p>
                <p style={color}>Css head style ou de arquivo de cabeça</p>
                <p className='cor'> CSS Arquivo Externo</p>
                <a className="ancora"
                    href='https://www.youtube.com/cfbcursos' 
                    target='_blank'
                    rel='noreferrer'>Canal no Youtube
                </a>
            </section>
        </>
    )
}