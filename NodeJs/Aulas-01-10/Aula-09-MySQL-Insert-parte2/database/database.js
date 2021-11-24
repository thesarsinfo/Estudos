const conectar = async () => {
    if(global.conexao && global.conexao.state != 'disconected'){
        return global.conexao
    }
    const mysql = require('mysql2/promise')
    const conexaoString = mysql.createConnection("mysql://root:b4B4D0GP0K@localhost:3306/saraivaestudos");
    console.log('Conexao ao banco')
    global.conexao = conexaoString;
    return conexaoString;
}

const todosClientes = async () => {
    const conexaoString = await conectar()
    const [linhas] = await conexaoString.query('SELECT * FROM tb_clientes');
    return await linhas
}

const insereClientes = async (cliente) => {
    const conexaoString = await conectar()
    //id é auto incremento
    const sql = 'INSERT INTO tb_clientes (V_NOME_CLIENTE,V_IDADE_CLIENTE) VALUES (?,?)'
    const valores = [cliente.nome,cliente.idade]

    await conexaoString.query(sql,valores);    
}


module.exports = {todosClientes,insereClientes}