import React from "react";
import CarroClasse24 from "./classe24/CarroClasse24";

export default function Aula24(){

    return (
        <>
            <h3>Aula 24</h3>
            <p>Metodo bind se trata de ligação ou mudar o conceito de this
            apontando para outro elementos
            </p>
            <CarroClasse24
                fator={2}
            />
        </>
    )
}