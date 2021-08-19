
const menus = document.querySelectorAll('[data-menu]');
const cssAtivo ='ativo';

menus.forEach(function(elem)
{
   elem.addEventListener("click",function()
   {
      
      for(let i = 0; i < menus.length; i++)
      {
         menus[i].classList.remove(cssAtivo);
      }
      elem.classList.add(cssAtivo);
   })
})

const btnMenu = document.getElementsByClassName('btnPointer')[0];
const menu = document.getElementsByClassName('menu')[0];

btnMenu.addEventListener('click',function()
{
   menu.classList.toggle('menuAberto');
})

