import React, { useState } from "react";
import CalculadoraBotao from "./calculadora-componentes/Calculadora-Botao";


//css
import './Aula33_34.css'
import DisplayCalculadora from "./calculadora-componentes/DisplayCalculadora";


export default function Aula33_34(){
    const[valorTela,setarValorTela]=useState('')
    const[resultado,setarResultado]=useState(0)
    const[acumulador,setarAcumulador]=useState(0)
    const[operado,setarOperado]=useState(false)



    return (
        <section>
            <article>
                <h3>Aula 33 e 34</h3>
                <p>Criando uma calculadora simples em react</p>
            </article>        
                <div className={'flexivel centro'}> 
                    <DisplayCalculadora
                    valor={valorTela}
                    resultado={resultado}
                    />
                </div>
                <div className={'flexivel centro'}> 
                    <CalculadoraBotao simbolo={'AC'}                       
                        setOperado={setarOperado}
                        setValorTela={setarValorTela}
                        setResultado={setarResultado}
                        setAcumulador={setarAcumulador}
                    />
                    <CalculadoraBotao simbolo={'('}
                        valorTela={valorTela}
                        setValorTela={setarValorTela}
                    />
                    <CalculadoraBotao simbolo={')'}
                        valorTela={valorTela}
                        setValorTela={setarValorTela}
                        
                    />
                    <CalculadoraBotao simbolo={'/'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    resultado={resultado}

                    setOperado={setarOperado}
                    />
                </div>
                <div className={'flexivel centro'}> 
                    <CalculadoraBotao simbolo={'7'}   
                    operado={operado}                
                    valorTela={valorTela}                    
                    setValorTela={setarValorTela}
                    />
                    <CalculadoraBotao simbolo={'8'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                   
                    />
                    <CalculadoraBotao simbolo={'9'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    
                    />
                    <CalculadoraBotao simbolo={'*'}   
                    valorTela={valorTela}                 
                    setValorTela={setarValorTela}
                    resultado={resultado}
                    setOperado={setarOperado}
                    />
                </div>
                <div className={'flexivel centro'}> 
                    <CalculadoraBotao simbolo={'4'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    
                    />
                    <CalculadoraBotao simbolo={'5'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    
                    />
                    <CalculadoraBotao simbolo={'6'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    
                    />
                    <CalculadoraBotao simbolo={'-'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    resultado={resultado}
                    setOperado={setarOperado}
                    />
                </div>
                <div className={'flexivel centro'}> 
                    <CalculadoraBotao simbolo={'1'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                     />
                    <CalculadoraBotao simbolo={'2'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    />
                    <CalculadoraBotao simbolo={'3'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    />
                    <CalculadoraBotao simbolo={'+'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    resultado={resultado}
                    setOperado={setarOperado}
                    />
                </div>
                <div className={'flexivel centro'}> 
                    <CalculadoraBotao simbolo={'0'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    />
                    <CalculadoraBotao simbolo={'.'}
                    valorTela={valorTela}
                    setValorTela={setarValorTela}
                    />
                    <CalculadoraBotao simbolo={'<-'}
                    valorTela={valorTela}
                    operado={operado}
                    acumulador={acumulador}
                    resultado={resultado}
                    setValorTela={setarValorTela}
                    setOperado={setarOperado}
                    
                    />
                    <CalculadoraBotao simbolo={'='}
                    valorTela={valorTela}
                    operado={operado}
                    setAcumulador={setarAcumulador}
                    setResultado={setarResultado}
                    setOperado={setarOperado}

                    />
                </div>
            </section>
        
        
        
    )
}