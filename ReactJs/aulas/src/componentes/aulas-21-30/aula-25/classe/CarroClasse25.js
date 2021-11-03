import React from "react";

export default class CarroClasse25 extends React.Component{

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
    OcultarCarro(){

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
    //funções de Montagem
    componentDidMount(){
        console.log("O componente da aula 25 foi montado")
    }  
    // Obs: Primeiro ele chama o render depois o did mount
    componentDidUpdate(){
        console.log("DidUpdate O carro foi atualizado Aula 25")
    }
    componentWillUnmount(){
        console.log("willunmount O carro foi removido Aula 25")

    }
    render(){
        console.log('chamando o render da classe 25')
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