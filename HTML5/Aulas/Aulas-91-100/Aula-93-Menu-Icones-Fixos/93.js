
const menu = document.querySelectorAll('[data-menu]');
const cssAtivo ='ativo';

menu.forEach(function(elem)
{
   elem.addEventListener("click",function()
   {
      
      for(let i = 0; i < menu.length; i++)
      {
         menu[i].classList.remove(cssAtivo);
      }
      elem.classList.add(cssAtivo);
   })
})


