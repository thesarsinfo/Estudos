sphereSize = SphereSize();
sphereVolume = CalculateSphereSize(sphereSize);
console.log("VOLUME = " + sphereVolume.toFixed(3));
alert("VOLUME = " + sphereVolume.toFixed(3));

function SphereSize()
{
    sphereSize = parseFloat(prompt("Digite o tamanho da espera!"));
    return sphereSize;
}
function CalculateSphereSize(sphereSize)
{
    const pi = 3.14159, sphereFormula = 4/3.0;
    let sphereVolume;
    sphereVolume = sphereFormula * pi * Math.pow(sphereSize, 3);
    return sphereVolume;
}