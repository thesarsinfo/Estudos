import React from "react";

export default function Aula13(){

    const carros = ['HRV','Golf','Focus','Cruze','Argo']
    const listaCarros = carros.map(
        (c,i) => {
            return <li key={i}> Indice: {i} - Carro: {c}</li>
        }
    )

    const carrosJson = [
        {categoria: "Esporte", preco: "110000.00", modelo: "Golf GTI"},
        {categoria: "Esporte", preco: "120000.00", modelo: "Camarro"},
        {categoria: "SUV", preco: "85000.00", modelo: "HRV"},
        {categoria: "SUV", preco: "83000.00", modelo: "T-Cross"},
        {categoria: "Utilitario", preco: "125000.00", modelo: "Hillux"},
        {categoria: "Utilitario", preco: "90000.00", modelo: "Ranger"}
    ]
    const listaCarrosJson = carrosJson.map(
        (c,i) => {
            return <li key={i}> Indice: {i} -
                     Categoria: {c.categoria} -
                     Modelo: {c.modelo} -
                     Preço: R$ {c.preco} 
            </li>
        }
    )
    return (
        <>
            <h3>Aula 13</h3>
            <p>Manipulação de elementos de lista usando MAP do javascript</p>
            <ul>{listaCarros}</ul>
            <ul>{listaCarrosJson}</ul>
        </>
    )
}