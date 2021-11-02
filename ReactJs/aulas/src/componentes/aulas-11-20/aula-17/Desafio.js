import React ,{useState} from 'react';  
import DesafioNota from './desafio/DesafioNota';
import DesafioResultado from './desafio/DesafioResultado';

export default function Desafio(){

    const [notas, setarNotas] = useState({'nota1':'0','nota2':'0','nota3':'0','nota4':'0'})
    const handleChangeNotas = (e) => {
        if (e.target.getAttribute('name') === 'nota1'){
            setarNotas({'nota1':e.target.value,'nota2':notas.nota2,'nota3':notas.nota3,'nota4':notas.nota4})
        }
        else if (e.target.getAttribute('name') === 'nota2'){
            setarNotas({'nota1':notas.nota1,'nota2':e.target.value,'nota3':notas.nota3,'nota4': notas.nota4})
        }
        else if (e.target.getAttribute('name') === 'nota3'){
            setarNotas({'nota1': notas.nota1,'nota2':notas.nota2,'nota3': e.target.value,'nota4': notas.nota4})
        }
        else if (e.target.getAttribute('name') === 'nota4'){
            setarNotas({'nota1': notas.nota1,'nota2':notas.nota2,'nota3': notas.nota3,'nota4':e.target.value})
        }
    }

    return (

        <>
            <h3> Desafio Correspondente da aula 17</h3>
            <p> Objetivo é utilizar apenas um user state com 2 componentes filhos</p>
            <DesafioNota
            num={1}
            nome={'nota1'}
            nota={notas.nota1}
            change={(e) => handleChangeNotas(e)}
            />
            <DesafioNota
            num={2}
            nome={'nota2'}
            nota={notas.nota2}
            change={(e) => handleChangeNotas(e)}
            />
            <DesafioNota
            num={3}
            nome={'nota3'}
            nota={notas.nota3}
            change={(e) => handleChangeNotas(e)}
            />
            <DesafioNota
            num={4}
            nome={'nota4'}
            nota={notas.nota4}
            change={(e) => handleChangeNotas(e)}
            />
            <DesafioResultado
            somaNotas=  {parseFloat(notas.nota1) + parseFloat(notas.nota2) +
                        parseFloat(notas.nota3) + parseFloat(notas.nota4) 
                        }
            />
        </>
    )
}