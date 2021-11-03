import React from "react";

export default class CarroClasse24 extends React.Component{

    constructor(props){
        super(props)
        this.modelo = 'HRV'
        this.state ={
            ligado:false,
            velAtual:0
        }
        this.ligarDesligar = this.LigarDesligar.bind(this)
        this.acelerar = this.Acelerar.bind(this)
    }
    LigarDesligar(){                
        //this.setState({ligado:!this.state.ligado})       
        this.setState(
            (state) =>(
                {ligado:!state.ligado}
            )
        )
    } 
    Acelerar(){
        this.setState(
            (state,props) => (
                {velAtual: state.velAtual + props.fator}
            )
        )
    }   

    render(){
        return (
            <>
                <h1>Meu Carro</h1>
                <p>Modelo: {this.modelo}</p>
                <p>Ligado: {this.state.ligado ? "Ligado" : "Desligado"}</p>
                <p>Vel.Atual: {this.state.velAtual}</p>
                <button onClick={this.ligarDesligar}>
                {this.state.ligado ? "Desligar" : "Ligar"}</button>
                <button onClick={this.acelerar}>Acelerar</button>
            </>
        )
    }
}