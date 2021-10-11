
function gerenciarImagens(c)
{
   let x;
   x = document.getElementsByClassName("img")

   for (let i = 0; i < x.length; i++)
   {
      x[i].style.display = "none";
   }
   if (c == 'tudo')
   {
      for (let i = 0; i < x.length; i++)
      {
         x[i].style.display = "block";
      }
   }
   else
   {
      x = document.getElementsByClassName(c)
      for (let i = 0; i < x.length; i++)
      {
         x[i].style.display = "block";
      }
   }

}

let btns = document.getElementsByClassName("btn");
for (let i = 0; i < btns.length; i++)
   {
      btns[i].addEventListener('click',function()
      {
         let btnAtual = document.getElementsByClassName("ativo")[0];
         btnAtual.className =  btnAtual.className.replace("ativo","");
         this.className += " ativo"; 
      }) 
   }
gerenciarImagens("tudo");