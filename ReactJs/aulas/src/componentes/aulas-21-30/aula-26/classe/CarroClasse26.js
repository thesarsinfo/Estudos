import React from "react";

export default class CarroClasse26 extends React.Component{

    constructor(props){
        //Para permitir passagem de parametros
        super(props)      
        //Configuração de state  
        this.state={
            canal:'CFB Cursos',
            curso:'React',
            ativo:true,
            nome:this.props.nomeAluno
        }     
        this.status = this.props.status
        //Bindagem
        this.ad = this.AtivarDesativar.bind(this)
        //Instruções do construtor  
    }    
    //função manipular state    
    AtivarDesativar(){
        this.setState(
            (state) => ({ 
                ativo: !state.ativo
            })
        )
    }
    componentDidMount(){
        console.log("Componente foi criado");
    }
    componentDidUpdate(){
        console.log("Componente foi atualizado");
    }
    componentWillUnmount(){
            console.log("O componente foi desmontado")
    }
    //render chama primeiro
    
    render(){
       
        return (
            
            <>
                <h4>Componente de Classe</h4>
                {/*chamada da função com bind*/}
                 <button onClick={this.ad} >Ativar Desativar</button>
            </>
        )
    }
}