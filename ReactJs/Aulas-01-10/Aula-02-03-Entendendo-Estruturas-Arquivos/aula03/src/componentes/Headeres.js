import React from "react";
import Logo from './imgs/logo2.png' //Aula 5

export default function Headeres()
{
    return(
        <header>
            <img src={Logo} alt="logo"/>
            <h1>Saraiva Estudos</h1>
        </header>
    )
}