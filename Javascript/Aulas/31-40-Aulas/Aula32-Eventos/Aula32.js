/* 
Aula 32 eventos Associando a Eventos a funções
*/
function mudaCor(obj , cor)
{
    obj.style.backgroundColor = cor;
}
function mudaPosicao(obj)
{
    obj.style.position="absolute";
    obj.style.left = Math.random() * 500 + "px";
    obj.style.top = Math.random() * 500 + "px";
};
function ola()
{
    let data = new Date();
    let hora = data.getHours();
    let cumprimentos = " ";
    if (hora < 12)
    {
        cumprimentos = "Bom Dia";
    } else if (hora < 18)
    {
        cumprimentos = "Boa Tarde";
    }else
    {
        cumprimentos = "Boa Noite";
    }
    alert("Olá " + cumprimentos);

}