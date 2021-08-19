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

function clickModal(img)
{
   // Receber elementos
   const janelaModal = document.getElementById('janelaModal');
   const imgModal =  document.getElementById('imgModal');
   const txtModal =  document.getElementById('txtModal');
   const btnFechar =  document.getElementById('btnFechar');

   janelaModal.classList.remove('escondeJanelaModal');
   janelaModal.classList.add('mostraJanelaModal');

   //inserindo a imagem

   imgModal.src = img.src; // img.src é devido ao fato de no parametro 
   //estamos passando o proprio elemento img
   imgModal.alt = img.alt;
   txtModal.innerHTML = img.alt;

   //fechar elemento

   btnFechar.onclick = function()
   {
   janelaModal.classList.add('escondeJanelaModal');
   janelaModal.classList.remove('mostraJanelaModal');
   
   }

}