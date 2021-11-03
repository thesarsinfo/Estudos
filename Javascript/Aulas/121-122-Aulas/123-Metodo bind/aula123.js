function carro(){
    let velMax = 200;
    console.log(this.cor)
}
let detalhes = {
    cor: 'Branco',
    marca: 'VW',
    modelo: 'Golf'   
}

let carroLigarDetalhes = carro.bind(detalhes);


carroLigarDetalhes()