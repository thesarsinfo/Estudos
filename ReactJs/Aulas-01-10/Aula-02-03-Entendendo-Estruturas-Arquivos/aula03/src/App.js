import React , {useState} from 'react'
import './App.css'
import Headeres from './componentes/Headeres'
import Corpo from './componentes/Corpo'
import Relogio from './componentes/Relogio';
import Numero from './componentes/Numero';
import LedVermelho from './componentes/LedVermelho';
import LedVerde from './componentes/LedVerde';




function App() {
  //retornando uma função Aula 3
  const variavelQualquer = () =>  
  {    
    return ('Estudando react');
  }

  const canaliza2 = 'Saraiva Estudos';
  const cursera = 'Curso de React';
  const textoDestaque = {
    color:'#00f',
    fontSize: '23px'

  }
  // eslint-disable-next-line no-lone-blocks
  //*A-010 Codigo para aula 10*/}
  const [num, setarNum] = useState(10);
  let n1 = 35;
    
   // eslint-disable-next-line no-lone-blocks
   //*A-011 Codigo para aula 11*/}
  const [ligado, setLigado] = useState(false)
   
   //*A-012 Codigo para aula 12*/}
   const vermelhoCor = {color:'#f00'};
   const verdeCor = {color:'#0f0'};
   const azulCor = {color:'#00f'};
   
   const [log, setarLogar] = useState(false)

   const cumprimentar = () => {
     if (log){
        const hora = new Date().getHours()
        if(hora >=0 && hora < 13){
          return <p style={vermelhoCor}>Bom dia Amiguinho</p>
        }
        else if(hora >=13 && hora < 18){
          return <p style={verdeCor}>Bom tarde Amiguinho</p>
        }
        else{
          return <p style={azulCor}>Bom Noite Amiguinho</p>
        }
     }      
   }  
   const msgLogin = () => {
     return 'Usuario Logado'
   }
   const msgLogoff = () => {
    return 'Favor Logar'
  }

  return (
    <section>
      <header> 
        <h2>Temos um data-bindind na aula 3{cursera}</h2>
        {/* A-03-Concatenando um data-binding com um texto*/}
        <p> {'Uma concatenação de ' + canaliza2}</p>      
        <p> Vamos ver no que dar!</p> 
        <h5> Retorno da função {variavelQualquer()}</h5>
      </header>
      <picture> 
        <p>Imagem veio de source foi mudada na aula 5 </p>
       
        <p>Imagem vindo da pasta public</p> 
        <img src="/imgs/eu.png" alt="Minha foto so que na pasta public"/>
      </picture>      
      <section>
        <h3>Aula 5</h3> 
        <p>Inserindo abaixo o componente header</p>
        <Headeres/>
        <p>Inserindo o componente corpo</p>
        
      </section>
      <section>
        <h3>Aula 6</h3>
       <p>Trabalhando com props</p>
      </section>
      <section>
        <h3>Aula 7</h3>
        <p>trabalhando com funcoes</p>
        <Corpo/>
      </section>
      <section className='caixa'>
        <h3 style={{color:'#f00', fontSize:'40px'}}>Aula 8</h3>
        <p style={textoDestaque} > trabalhando com CSS no React </p>
        <p className='pTexto'> trabalhando com CSS usando css externo no react </p>
        <a href='https://www.youtube.com/cfbcursos' target='_parent'>CFB Cursos</a>

      </section>
      <section>
        <h3>Aula 9</h3>
        <p>Entedendo a renderização no React</p>
        <p>Mostrando a hora</p>
        <Relogio/>

      </section>
      <section>
        <h3>Aula 10</h3>
        <p>Conhecendo hook state</p>
        <p>Componente Numero foi criado</p>

        <p> Valor do normal do n1 : {n1}</p>
        <p> Valor do state num em App: {num}</p> 
        <Numero 
        num={num} 
        setNum={setarNum}
        />         
      </section>
      <section>
        <h3>Aula 11</h3>
        <p>Trabalhando com eventos</p>
        <picture>{ligado ? <LedVerde/> : <LedVermelho/>}</picture>
        <button onClick={() => setLigado(!ligado)}>{ligado?'Desligar':'Ligar'}</button>
      </section>
      <section>
        <h3>Aula 12</h3>
        <p>renderização condicional</p>

        {cumprimentar()}
        <p>{log?msgLogin():msgLogoff()}</p>
        <button onClick={() => setarLogar(!log)}>{log?'Deslogar':'Logar'}</button>

      </section>

   </section>
  );
}

export default App;
