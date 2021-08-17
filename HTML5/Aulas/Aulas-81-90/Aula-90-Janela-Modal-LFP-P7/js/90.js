const elementos = document.querySelectorAll('[data-anima]');
const animacaoClasse = 'animacao';

function animaScroll()
{
   const topoPaginaJanela = window.pageYOffset + ((window.innerHeight * 3)/4); 
   //executa animação a 3/4 da janela do usuário , mas podemos usar algo fixo
   //caso se quisemos.
   elementos.forEach( function(elemento)
   {
      if(topoPaginaJanela > elemento.offsetTop)
      {
         elemento.classList.add(animacaoClasse);

      }
      else
      {
         elemento.classList.remove(animacaoClasse);
      }
   });
}
if (elementos.length)
{
   window.addEventListener('scroll', function()
   {
      animaScroll();
   })
}