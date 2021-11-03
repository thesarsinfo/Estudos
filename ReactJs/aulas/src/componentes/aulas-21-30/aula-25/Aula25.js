import React,{useState} from "react";
import CarroClasse25 from "./classe/CarroClasse25";


export default function Aula25(){
    const [carro, setCarro]=useState(true)
    return (
        <>
            <h3>Aula 25</h3>
            <p>Ciclos de Vida dos componentes React.
            </p>
            <h4> Metodos chamados na montagem de um componente</h4>
                <li>constructor()</li>
                <li>static getDelivedStateFromProps()</li>
                <li>render()</li>
                <li>componentDidMount()</li>
            <h4> Metodos chamados durante atualização de componente durante props ou state </h4>
                <li>static getDerivedStateFromProps()</li>
                <li>shouldComponentUpdate()</li>
                <li>render()</li>
                <li>getSnapshotBeforeUpdate()</li>
                <li>componentDidUpdate()</li>
            <h4> Metodos chamados na remoção de um componente</h4>
                <li>componentWillUnmount()</li>
            <h4> Metodos chamados durante erro</h4>
                <li>static getDerivedStateFromError()</li>
                <li>componentDidCatch()</li>  

            {carro ? <CarroClasse25 fator={1} /> : '' }              
            
            <button onClick={() => setCarro(!carro)}>Ocultar</button>
      </>
    )
}