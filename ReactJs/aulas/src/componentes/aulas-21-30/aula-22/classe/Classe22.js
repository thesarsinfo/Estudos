import React from "react";

export default class ClasseAula22 extends React.Component{

    constructor(props){
        super(props)
        
    }
    render(){
        return (
            <>
                <h4>Componente da classe da Aula 22</h4>
                <p>Titulo {this.props.titulo}</p>
            </>
        )
    }
}