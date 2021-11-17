import React from "react";
//router
import {Routes ,Route,Link} from "react-router-dom"
//componentes
import Aula03 from "./componentes/aulas-01-10/aula-03/Aula03";
import Aula04 from "./componentes/aulas-01-10/aula-04/Aula04";
import Aula05 from "./componentes/aulas-01-10/aula-05/Aula05";
import Aula06 from "./componentes/aulas-01-10/aula-06/Aula06";
import Aula07 from "./componentes/aulas-01-10/aula-07/Aula07";
import Aula08 from "./componentes/aulas-01-10/aula-08/Aula08";
import Aula09 from "./componentes/aulas-01-10/aula-09/aula09";
import Aula10 from "./componentes/aulas-01-10/aula-10/Aula10";
import Aula11 from "./componentes/aulas-11-20/aula-11/Aula11";
import Aula12 from "./componentes/aulas-11-20/aula-12/Aula12";
import Aula13 from "./componentes/aulas-11-20/aula-13/Aula13";
import Aula14 from "./componentes/aulas-11-20/aula-14/Aula14";
import Aula15 from "./componentes/aulas-11-20/aula-15/Aula15";
import Aula16 from "./componentes/aulas-11-20/aula-16/Aula16";
import Desafio from "./componentes/aulas-11-20/aula-17/Desafio";
import Aula18 from "./componentes/aulas-11-20/aula-18/Aula18";
import Aula19 from "./componentes/aulas-11-20/aula-19/Aula19";
import Aula20 from "./componentes/aulas-11-20/aula-20/Aula20"
import Aula21 from "./componentes/aulas-21-30/aula-21/Aula21";
import Aula22 from "./componentes/aulas-21-30/aula-22/Aula22";
import Aula23 from "./componentes/aulas-21-30/aula-23/Aula23";
import Aula24 from "./componentes/aulas-21-30/aula-24/Aula24";
import Aula25 from "./componentes/aulas-21-30/aula-25/Aula25";
import Aula26 from "./componentes/aulas-21-30/aula-26/Aula26";
import Aula27 from "./componentes/aulas-21-30/aula-27/Aula27";
import Aula28 from "./componentes/aulas-21-30/aula-28/Aula28";
import Aula29 from "./componentes/aulas-21-30/aula-29/Aula29";
import Aula30 from "./componentes/aulas-21-30/aula-30/Aula30";
import Aula31 from "./componentes/aulas-31-40/aula-31/Aula31";
import AULA33_34 from "./componentes/aulas-31-40/aula-33-34/AULA33_34";
import Aula40 from "./componentes/aulas-31-40/aula-40/Aula40";
import AULAS_3537 from "./componentes/aulas-31-40/aula-35-37/AULAS_3537";
import AULAS_3839 from "./componentes/aulas-31-40/aula-38-39/AULAS_3839";
import Aula41 from "./componentes/aulas-41-44/aula-41/Aula41";
import Aula42 from "./componentes/aulas-41-44/aula-42/Aula42";
import Aula43 from "./componentes/aulas-41-44/aula-43/Aula43";

export default function App(){  
  
  return(
    <>
      <header >
        <Link style={{display:'block'}} to='/'>Home</Link>
        <Link style={{display:'block'}} to='/estrutura-basica'> 
        Aula 03 - estrutura-basica </Link>
        <Link style={{display:'block'}} to='/insersao-imagens'> 
        Aula 04 - insersao-imagens </Link>
        <Link style={{display:'block'}} to='/criando-componentes'> 
        Aula 05 - criando-componentes </Link>
        <Link style={{display:'block'}} to='/enviar-propriedades-props'> 
        Aula 06 - enviar-propriedades-props </Link>
        <Link style={{display:'block'}} to='/enviar-funcoes-componentes'> 
        Aula 07 - enviar-funcoes-componentes </Link>
        <Link style={{display:'block'}} to='/css-react'> 
        Aula 08 - css-react </Link>
        <Link style={{display:'block'}} to='/renderizacao-react'> 
        Aula 09 - renderizacao-react </Link>
        <Link style={{display:'block'}} to='/state-estrutura-basica'> 
        Aula 10 - state-estrutura-basica </Link>
        <Link style={{display:'block'}} to='/eventos-react'> 
        Aula 11 - eventos-react </Link>
        <Link style={{display:'block'}} to='/renderizacao-condicional'> 
        Aula 12 - renderizacao-condicional </Link>
        <Link style={{display:'block'}} to='/lista-react-map'> 
        Aula 13 - lista-react-map </Link>
        <Link style={{display:'block'}} to='/formularios'> 
        Aula 14 - formularios </Link>
        <Link style={{display:'block'}} to='/state-estrutura'> 
        Aula 15 - state-estrutura </Link>
        <Link style={{display:'block'}} to='/elevacao-state'> 
        Aula 16 - elevacao-state </Link>
        <Link style={{display:'block'}} to='/desafio-state-unico'> 
        Aula 17 - desafio-state-unico </Link>
        <Link style={{display:'block'}} to='/contecao-react'> 
        Aula 18 - contecao-react </Link>
        <Link style={{display:'block'}} to='/hook-useeffect'> 
        Aula 19 - hook-useeffect </Link>
        <Link style={{display:'block'}} to='/local-storage'> 
        Aula 20 - local-storage </Link>
        <Link style={{display:'block'}} to='/criando-componentes-classe'> 
        Aula 21 - criando-componentes-classe </Link>
        <Link style={{display:'block'}} to='/state-classe'> 
        Aula 22 - state-classe </Link>
        <Link style={{display:'block'}} to='/manipulacao-state-classe'> 
        Aula 23 - manipulacao-state-classe </Link>
        <Link style={{display:'block'}} to='/bind-metodo-classe'> 
        Aula 24 - bind-metodo-classe </Link>
        <Link style={{display:'block'}} to='/ciclo-vida-componente'>
        Aula 25 -ciclo-vida-componente </Link>
        <Link style={{display:'block'}} to='/revisao-geral'> 
        Aula 26 - revisao-geral</Link>
        <Link style={{display:'block'}} to='/variaveis-globais'>
        Aula 27 - variaveis-globais </Link>
        <Link style={{display:'block'}} to='/router-nativo'> 
        Aula 28 - router-nativo </Link>
        <Link style={{display:'block'}} to='/tabela-html'> 
        Aula 29 - tabela-html </Link>
        <Link style={{display:'block'}} to='/calculadora-imc'> 
        Aula 30 - calculadora-imc </Link>
        <Link style={{display:'block'}} to='/calculadora-imc-desafio'> 
        Aula 31 - calculadora-imc-desafio </Link>
        <Link style={{display:'block'}} to='/calculadora-simples'> 
        Aula 33 e 34 - calculadora-simples </Link>        
        <Link style={{display:'block'}} to='/jogo-velha'> 
        Aula 35 a 37 - jogo-velha </Link>
        <Link style={{display:'block'}} to='/construindo-consumindo-api'> 
        Aula 38 a 39 - construindo-consumindo-api</Link>
        <Link style={{display:'block'}} to='/consumo-api-funcional'> 
        Aula 40 - consumo-api-funcional </Link>
        <Link style={{display:'block'}} to='/consumo-api-funcional-nativo'> 
        Aula 41 - consumo-api-funcional-nativo </Link>
        <Link style={{display:'block'}} to='/utilizando-router'> 
        Aula 42 - utilizando-router </Link>
        <Link style={{display:'block'}} to='/atributo-key'> Aula 43 - atributo-key </Link>
        
      </header> 
      <main>
        <Routes>
          <Route exact path='/estrutura-basica' element={<Aula03/>} />          
          <Route exact path='/insersao-imagens' element={<Aula04/>} />
          <Route exact path='/criando-componentes' element={<Aula05/>} />
          <Route exact path='/enviar-propriedades-props' element={<Aula06/>} />
          <Route exact path='/enviar-funcoes-componentes' element={<Aula07/>} />
          <Route exact path='/css-react' element={<Aula08/>} />
          <Route exact path='/renderizacao-react' element={<Aula09/>} />
          <Route exact path='/state-estrutura-basica' element={<Aula10/>} />
          <Route exact path='/eventos-react' element={<Aula11/>} />
          <Route exact path='/renderizacao-condicional' element={<Aula12/>} />
          <Route exact path='/lista-react-map' element={<Aula13/>} />
          <Route exact path='/formularios' element={<Aula14/>} />
          <Route exact path='/state-estrutura' element={<Aula15/>} />
          <Route exact path='/elevacao-state' element={<Aula16/>} />
          <Route exact path='/desafio-state-unico' element={<Desafio/>} />
          <Route exact path='/contecao-react' element={<Aula18/>} />
          <Route exact path='/hook-useeffect' element={<Aula19/>} />
          <Route exact path='/local-storage' element={<Aula20/>} />
          <Route exact path='/criando-componentes-classe' element={<Aula21/>} />
          <Route exact path='/state-classe' element={<Aula22/>} />
          <Route exact path='/manipulacao-state-classe' element={<Aula23/>} />
          <Route exact path='/bind-metodo-classe' element={<Aula24/>} />
          <Route exact path='/ciclo-vida-componente' element={<Aula25/>} />
          <Route exact path='/revisao-geral' element={<Aula26/>} />
          <Route exact path='/variaveis-globais' element={<Aula27/>} />
          <Route exact path='/router-nativo' element={<Aula28/>} />
          <Route exact path='/tabela-html' element={<Aula29/>} />
          <Route exact path='/calculadora-imc' element={<Aula30/>} />
          <Route exact path='/calculadora-imc-desafio' element={<Aula31/>} />
          <Route exact path='/calculadora-simples' element={<AULA33_34/>} />
          <Route exact path='/jogo-velha' element={<AULAS_3537/>} />
          <Route exact path='/construindo-consumindo-api' element={<AULAS_3839/>} />
          <Route exact path='/consumo-api-funcional' element={<Aula40/>} />
          <Route exact path='/consumo-api-funcional-nativo' element={<Aula41/>} />
          <Route exact path='/utilizando-router' element={<Aula42/>} /> 
          <Route exact path='/atributo-key'  element={<Aula43/>} />         
       
        </Routes>
      </main>
    </>
  )
}