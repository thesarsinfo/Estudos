import React from "react";
import Logo from "../../../imgs/logo2.png"

export default function Header() {

    return (
        <header>
            <p>Nesse caso um componente dentro do outro e é componente Header.</p>
            <img src={Logo} alt="Logo"/>
        </header>
    )
}