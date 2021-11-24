(async () => {
    
    const database = require('./database/database');
    console.log('Inserir novo cliente')
    let inserirNome = "";
    let inserirIdade = "";
    let identificarId = ""
    
    mensagem = (inserirNome != "" || inserirIdade != "")? 
        await database.insereClientes({nome:inserirNome, idade:inserirIdade}) :
        'Campos vazios'
    console.log(mensagem);

    
    inserirNome = ""
    inserirIdade = ""
    console.log('Alterando cliente')
    mensagem = (inserirNome != "" || inserirIdade != "" || identificarId != "")  
        ? await database.alterarClientes(identificarId, {nome:inserirNome, idade:inserirIdade}) 
        : 'Campo Nome, idade ou id estão vazios';   
    console.log(mensagem)
    console.log('O cliente ' + identificarId + ' foi atualizado');
    console.log('Deletando Cliente');
    mensagem = (identificarId != "")  
        ? await database.deletarCliente(identificarId) 
        : 'Campo id vazio';  


    console.log('Obtendo todos os clientes')
    const clientes = await database.todosClientes();
    console.log(clientes)
})()