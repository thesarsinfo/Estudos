import React , {useState} from "react";

export default function Formulario(){
    
    const [nome, setarNome]=useState('Digite o seu nome');
    const [carro, setarSelect]=useState('HRV')
    const handleChangeNome = (e) => {
        setarNome(e.target.value)
    }
    const handleClickClearNome = (e) => {
        const nomePadrao = 'Digite o seu nome'
        if (e.target.value === nomePadrao){
            setarNome('');
        }        
    }
    const handleChangeCarro = (e) => {
        setarSelect(e.target.value)
    }

    return (
        <>
            <label> Digite seu Nome: </label>
            <input
             type="text" 
             name="fnome"
             value={nome}
             onChange={(e) => handleChangeNome(e)}
             onClick={(e) => handleClickClearNome(e)}
              />
            <p> Nome digitado: {nome} </p>
            <label> Selecione um veiculo: </label>
            <select value={carro}
                    name = 'fCarro'
                    onChange={(e) => handleChangeCarro(e)}
            >
                <option value="HRV">HRV</option>
                <option value="Golf">Golf</option>
                <option value="Marea">Marea</option>
                <option value="Cruize">Cruize</option>
            </select>
            <label> Veiculo Selecionado: {carro} </label>
            
        </>
    )
}