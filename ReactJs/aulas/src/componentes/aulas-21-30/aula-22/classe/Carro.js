import React from "react";

export default class Carro extends React.Component{

    constructor(props){
        super(props)
        this.modelo = 'HRV'
        this.state ={
            ligado:false,
            velAtual:0
        }
    }
    LigarDesligar(){        
        this.setState({ligado:!this.state.ligado})         
    }    

    render(){
        return (
            <>
                <h1>Meu Carro</h1>
                <p>Modelo: {this.modelo}</p>
                <p>Ligado: {this.state.ligado ? "Ligado" : "Desligado"}</p>
                <p>Vel.Atual: {this.state.velAtual}</p>
                <button onClick={() => this.LigarDesligar()}>
                {this.state.ligado ? "Desligar" : "Ligar"}</button>
            </>
        )
    }
}