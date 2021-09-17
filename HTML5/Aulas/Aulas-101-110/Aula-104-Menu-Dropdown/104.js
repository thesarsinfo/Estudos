
function mostrarDropDown()
{
   document.getElementsByClassName("menudropdown-conteudo")[0].classList.toggle("mostrar-menu-dropdown");
}
window.onclick = function(event)
{
   if(!event.target.matches('.btndropdown'))
   {
      let dropdowns = document.getElementsByClassName("menudropdown-conteudo");
      for (let i = 0; i <dropdowns.length; i++)
      {
         let abertoDropdown = dropdowns[i];
         if (abertoDropdown.classList.contains('mostrar-menu-dropdown'))
         {
            abertoDropdown.classList.remove('mostrar-menu-dropdown');
         }
      }
   }
}
