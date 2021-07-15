//Aula 25 GetElementByTagName retorna todos elementos da tag p na pagina html por exemplo e ele retorna tudo e 
//volta em vetor trabalhamos com indice dele.
//let tagsP = document.getElementsByTagName("p")[3];
 let tagsP = document.getElementsByTagName("p");
 //alterando o estilo
tagsP[1].style.color = "#f00";
//formatando todos elementos
for (let i = 0 ; i < tagsP.length;i++)
{
    tagsP[i].style.color = "#f99";
}
 document.write(tagsP[0].innerHTML);

 //Selecionar todas tags diferentes iniciadas

 let todasTags = document.getElementsByTagName("*");
 todasTags[8].innerHTML = " Novo texto";
 todasTags[8].style.color = "#F08";