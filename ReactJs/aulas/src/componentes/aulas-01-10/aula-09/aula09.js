import React from "react";

export default function Aula09(){    

    return (
        <>
            <section>
                <h3> Aula 09 </h3>
                <p> Comprovando o uso real do React em chamar funções em tempo real</p>
                <p>{new Date().toLocaleTimeString()}</p>
            </section>
        </>
    )
}