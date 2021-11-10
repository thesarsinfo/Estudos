import React from "react";
//css
import './DisplayCalculadora.css'

export default class DisplayCalculadora extends React.Component {
    constructor(props){
        super(props);
    }

    render() {
        return (
            <div className='cssTela'>
                <span className='cssOperacao'>
                    {this.props.valor}
                </span>
                <span className='cssResultado'>
                    {this.props.resultado}
                </span>

            </div>
        )
    }

}