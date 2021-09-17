const nav = document.getElementsByTagName("nav")[0];
const topoNav = nav.offsetTop;
window.onscroll = function()
{
   fixarMenuNoTopo();
}
function fixarMenuNoTopo()
{
   if(window.pageYOffset >= topoNav)
   {
      nav.classList.add("fixoNoTopo");
   }
   else
   {
      nav.classList.remove("fixoNoTopo");

   }
} 
//distancia do elemento no seu topo em pixel ate o elemento pai (body) no topo
console.log(topoNav);