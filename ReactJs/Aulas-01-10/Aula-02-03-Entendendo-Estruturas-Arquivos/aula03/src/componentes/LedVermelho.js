import React from "react";
import LedImgVermelho from "./imgs/ledVermelho.png"
import "./LedVermelho.css"

export default function LedVermelho(){

    return(
        <img className="sizeLed" src={LedImgVermelho} alt="led vermelho"/>
    )
}
