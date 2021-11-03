import React from "react";

export default class Classe extends React.Component{
    constructor(props){
        super(props)
    }
    render(){
        return(
            <>
            <h2>Primeiro componente de classe</h2>
            <p>Canal: {this.props.canal}</p>
            <p>Canal: {this.props.curso}</p>
            </>
        )
    }
}

 