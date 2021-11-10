import React from "react";

export default class Inputs extends React.Component{
    constructor(props){
        super(props);
    }

    render(){
        return (
            <div>
                <input type="text" name={this.props.name} 
                value={this.props.dados} onChange={(e) => this.props.dadosMudados(e)}
                />
            </div>
        )
    }
}