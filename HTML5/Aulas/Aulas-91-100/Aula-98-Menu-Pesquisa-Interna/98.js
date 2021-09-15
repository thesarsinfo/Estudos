
function pesquisar()
{
   let input, filtro, menu , menuItens , links
   input = document.getElementById("pesquisa");
   filtro = input.value.toUpperCase();
   menu = document.getElementById('menu');
   menuItens = menu.getElementsByTagName("li");
   for ( let i = 0 ; i < menuItens.length; i++)
   {
      links = menuItens[i].getElementsByTagName("a")[0];
      if (links.innerHTML.toUpperCase()
                           .indexOf(filtro) > -1)
      // -1 = não encontrado
      {
         menuItens[i].style.display="";
      }
      else
      {
         menuItens[i].style.display="none";         
      }
   }
}