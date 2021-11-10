import React from "react";
//css
import './input.css'

export default class CalculadoraInput extends React.Component{
    constructor(props){
        super(props)
    }
    
    render(){
        return (
            <div>
                <input className={'AlturaTamanho'} type='text' value={this.props.digito}
                    
                />
            </div>
        )
    }
}