import React from "react";

export default class CalcularInputs extends React.Component{
    constructor(props){
        super(props);
        
    }

    render(){
        return (
            <div>
                
                <p>{this.props.resultado.toFixed(2)}</p>
            </div>
        )
    }
}