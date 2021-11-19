(async () => {
    const database = require('./database/database');
    console.log('Obter todos os clientes')
    const clientes = await database.todosClientes();
    console.log(clientes)
})()