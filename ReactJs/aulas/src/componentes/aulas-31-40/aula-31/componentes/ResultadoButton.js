import React from "react";

export default class ResultadoButton extends React.Component{
    constructor(props){
        super(props);
        
        
    }
    Calculo = () => {   
        console.log('Função chamada')
        this.props.setarResultado(this.props.entPeso / ( this.props.entAlt * this.props.entAlt))        
        
    }   

    render(){
       
        return (
            <div>
                <button onClick={() => this.Calculo()}>Calcular</button>
            </div>
        )
    }
}