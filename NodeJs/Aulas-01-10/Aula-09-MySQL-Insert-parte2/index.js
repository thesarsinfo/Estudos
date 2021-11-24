(async () => {
    const database = require('./database/database');
    console.log('Inserir novo cliente')
    const inserirNome = "";
    const inserirIdade = "";
    (inserirNome != "" || inserirIdade != "") ?  await database.insereClientes({nome:inserirNome, idade:inserirIdade}) 
                                : console.log('Campo Nome ou idade estão vazios');   

    console.log('Obtendo todos os clientes')
    const clientes = await database.todosClientes();
    console.log(clientes)
})()