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


module.exports = {todosClientes}