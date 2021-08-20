const acordeonArray = document.getElementsByClassName('acordeon');

for (let i = 0; i < acordeonArray.length; i++)
{
   acordeonArray[i].addEventListener("click", function()
   {
      this.classList.toggle('selecionado');
      const painel = this.nextElementSibling;
      (painel.style.maxHeight) ? painel.style.maxHeight = null 
         : painel.style.maxHeight = painel.scrollHeight + "px"   
   })
}