function controleMenu()
{
   const menu = document.getElementById("menus");
   if ( menu.style.display == "block")
   {
      menu.style.display = "none";
   }
   else
   {
      menu.style.display = "block";
   }
}