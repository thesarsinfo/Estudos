import React, { useState } from "react";

export default function Aula15(){

    const [form,setarForm]=useState({"nome":"","curso":"","ano":""});
    const handleChangeForm = (e) => {
        if(e.target.getAttribute('name') === 'fNome'){
            setarForm({"nome":e.target.value,"curso":form.curso,"ano":form.ano})
        }
        else if (e.target.getAttribute('name') === 'fCurso'){
            setarForm({"nome":form.nome,"curso":e.target.value,"ano":form.ano})
            
        }
        else if (e.target.getAttribute('name') === 'fAno') {
            setarForm({"nome":form.nome,"curso":form.curso,"ano":e.target.value})
        }
    }

    return (
        <>
            <h3>Aula 15</h3>
            <p>Trabalhando com 1 state para varios elementos do formulario</p>
            <label>Nome</label>
            <input  type='text'
                    name='fNome'
                    value={form.nome}
                    onChange={(e) => handleChangeForm(e)}
            /> <br/>
            <label>Curso</label>
            <input  type='text'
                    name='fCurso'
                    value={form.curso}
                    onChange={(e) => handleChangeForm(e)}
            /> <br/>
            <label>Ano</label>
            <input  type='text'
                    name='fAno'
                    value={form.ano}
                    onChange={(e) => handleChangeForm(e)}
            /> <br/>
            <p>Nome digitado: {form.nome} </p>
            <p>Curso digitado: {form.curso} </p>
            <p>Ano digitado: {form.ano} </p>

        </>
    )
}
