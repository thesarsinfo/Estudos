let numSlide = 1;
mostrarSlide(numSlide)

function mudarSlide(nslide)
{
   mostrarSlide(numSlide += nslide);
}
function slideAtual(nslide)
{
   mostrarSlide(numSlide = nslide);
}
function mostrarSlide(nslide)
{
   let i;
   let slides = document.getElementsByClassName("slide");
   let indicadores = document.getElementsByClassName("indicador");

   if(nslide >  slides.length)
   {
      numSlide = 1
   }
   if(nslide < 1)
   {
      numSlide = slides.length;
   }
   
   for(let i = 0; i<slides.length;i++)
   {
      slides[i].style.display ="none";
   }
   for(let i = 0; i<indicadores.length;i++)
   {
     indicadores[i].className  = indicadores[i].className.replace("ativo",""); 
   }
   slides[numSlide -1].style.display = "block";
   indicadores[numSlide -1].className += "ativo";
}