var x, y, z, n=0,ny = 1,rotInt,rotYINT;

function rotateYDiv()
{
    y = document.getElementById("d2");   
    x = document.getElementById("d3");
    z = document.getElementById("d4")
    clearInterval(rotYINT);
    rotYINT = setInterval("startYRotate()",10);
}

function startYRotate()
{
    ny += 1;    
    y.style.transform = "rotateY(" + ny + "deg)";
    y.style.webkitTransform = "rotateY(" + ny + "deg)";
    y.style.OTransform = "rotateY(" + ny + "deg)";
    y.style.mozTransform = "rotateY(" + ny + "deg)";
    x.style.transform = "rotateY(" + ny + "deg)";
    x.style.webkitTransform = "rotateY(" + ny + "deg)";
    x.style.OTransform = "rotateY(" + ny + "deg)";
    x.style.mozTransform = "rotateY(" + ny + "deg)";
    z.style.transform = "rotateY(" + ny + "deg) translate(200px 0px )";
    z.style.webkitTransform = "rotateY(" + ny + "deg) translate(200px , 0px)";
    z.style.OTransform = "rotateY(" + ny + "deg) translate(200px , 0px)";
    z.style.mozTransform = "rotateY(" + ny + "deg) translate(200px , 0px)";
    if (ny == 180 || ny >= 360)
    {
        clearInterval(rotYINT);
        if (ny >= 360)
        {
            ny=0;
        }
    }
}