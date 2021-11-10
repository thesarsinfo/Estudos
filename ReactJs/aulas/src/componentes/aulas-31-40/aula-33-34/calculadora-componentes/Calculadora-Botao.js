import React from "react";

//css
import './botao.css'



export default class CalculadoraBotao extends React.Component{
    constructor(props){
        super(props)
       
    }
    AddDigitoTela = (simbolo) => {
        console.log(simbolo)
        console.log(this.props.operado)
        if ((simbolo === '+' || simbolo === '-' ||
            simbolo === '/' || simbolo === '*') &&
             this.props.operado ){
            console.log("+-*/");
            this.props.setOperado(false)
            this.props.setValorTela(this.props.resultado + simbolo)
            return
        }
        if (this.props.operado){
            this.props.setValorTela(simbolo);
            this.props.setOperado(false);
            return
        }
        if (simbolo === 'AC'){
            this.LimparMemoria()
            return
        }
        if (simbolo === '<-' || simbolo === '=' ){
            this.Operacao(simbolo);
            return
        }
        
        const valorDigitadoTela  = this.props.valorTela + simbolo
        this.props.setValorTela(valorDigitadoTela);
        
    }
    LimparMemoria =() => {
        console.log('Funçao limpar memoria chamada')
        
        this.props.setOperado(false);        
        this.props.setValorTela('');        
        this.props.setResultado(0);        
        this.props.setAcumulador(0);
        return

    }
    Operacao = (oper) => {
        console.log(oper)
        if (oper === '<-') {
            console.log(oper  + "if verdadeiro" )

            let vTela = this.props.valorTela;
            console.log(vTela)

            vTela = vTela.substring(0,(vTela.length -1))
            this.props.setValorTela(vTela);
            this.props.setOperado(false)
            return
        }
        try {
            const r = eval(this.props.valorTela); //Calculo
            this.props.setAcumulador(r);
            this.props.setResultado(r);
            this.props.setOperado(true);
        }
        catch {
            this.props.setResultado('ERRO');
        }
    }

    render(){
        return (
            <div>
                <button className={'botao'} onClick={() => this.AddDigitoTela(this.props.simbolo)}>{this.props.simbolo}</button>
                
            </div>
        )
    }
}