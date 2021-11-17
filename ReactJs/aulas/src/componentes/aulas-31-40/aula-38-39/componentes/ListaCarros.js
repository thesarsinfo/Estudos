import React from "react";
import axios from "axios";

export default class ListaCarros extends React.Component{

    state={
        carros:[]
    }
    componentDidMount(){
        axios.get('https://apicfbcursosexemplo1.thiagosaraiva1.repl.co')
        .then(res =>{
            const dadosCarros = res.data
            this.setState({carros:dadosCarros})
        })
    }
    render(){
        return (
            <div>
                <div>
                    <h3>Aula 38 e 39</h3>
                    <p>Criando e Consumindo uma api </p>
                </div>
                {this.state.carros.map(
                    carro => <div key={carro.id}>{carro.id} -{carro.marca} - {carro.modelo}</div>
                )}
            </div>
        )
    }
}
