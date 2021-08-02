
var dv1,dv2,dv3,dv4;
troca = () =>
{
    objeto = event.target;
    objeto.style.backgroundImage = "url('c2.png')";
}
destroca = () =>
{
    objeto = event.target;
    objeto.style.backgroundImage = "url('c1.png')";
}
inicia = () =>
{
    dv1 = document.getElementById("dv1");
    dv2 = document.getElementById("dv2");
    dv3 = document.getElementById("dv3");
    dv4 = document.getElementById("dv4");

    dv1.addEventListener("mouseover",troca);
    dv1.addEventListener("mouseout",destroca);

    dv2.addEventListener("mouseover",troca);
    dv2.addEventListener("mouseout",destroca);

    dv3.addEventListener("mouseover",troca);
    dv3.addEventListener("mouseout",destroca);
    
    dv4.addEventListener("mouseover",troca);
    dv4.addEventListener("mouseout",destroca);
}

window.addEventListener("load",inicia);