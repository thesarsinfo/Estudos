
//evento é o evento de click no botao e nome das tabs é o id dos article tabs
const abrirTabs = (evento,nomeTabs) =>
{
   const conteudoTabs = document.getElementsByClassName("conteudoTab");
   for(let i = 0; i < conteudoTabs.length; i++)
   {
      conteudoTabs[i].style.display ="none"
   }
   //selecionando os botões pelo data
   const btnTabs = document.querySelectorAll('[data-btnTabs]')
   for(let i = 0; i < btnTabs.length; i++)
   {
      btnTabs[i].classList.remove('ativo');
   }
   document.getElementById(nomeTabs).style.display = "block";
   evento.currentTarget.classList.add("ativo")
}

document.getElementById('primeiro').click();
