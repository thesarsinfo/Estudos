import React,{useState} from "react";

const carros =[
    {categoria:"Esporte",preco:"110000",modelo:"Goft GTI"},
    {categoria:"Esporte",preco:"120000",modelo:"Camaro"},
    {categoria:"SUV",preco:"85000",modelo:"HRV"},
    {categoria:"SUV",preco:"83000",modelo:"T-Cross"},
    {categoria:"Utilitario",preco:"125000",modelo:"Hilux"},
    {categoria:"Utilitario",preco:"90000",modelo:"Ranger"}
]   
const retornaLinhas = (cat) => {
    const linhas=[]

    carros.forEach(
        (carro)=> {
            if(carro.categoria.toUpperCase() == cat.toUpperCase() || cat.toUpperCase() == ''){
                linhas.push(
                    <tr>
                        <td>{carro.categoria}</td>
                        <td>{carro.preco}</td>
                        <td>{carro.modelo}</td>
                    </tr>
                )
            }
        }
    )
    return linhas
}

const TabelaCarros = (cat) => {
    return (
        <table border='1' style={{borderCollapse:'collapse'}}>
            <thead>
                <tr>
                    <th>Categoria</th>
                    <th>Preço</th>
                    <th>Modelo</th>
                </tr>
            </thead>
            <tbody>
                {retornaLinhas(cat)}
            </tbody>
        </table>        
    )
}

const pesquisaCategoria = (cat, stateCat) => {
    return (
        <div>
            <label>Digite uma categoria</label>
            <input type="text" value={cat} 
            onChange={(e) => stateCat(e.target.value)}
            />
        </div>
        
    )
}

export default function Aula29(){

    const [categoria,setCategoria]=useState('')

    return (

        <>
            <h3>Aula 29</h3>
            <p>Exercicio usando tabelas</p>
            {TabelaCarros(categoria)}            
            <br/>
            {pesquisaCategoria(categoria,setCategoria)}
        </>
    )
}