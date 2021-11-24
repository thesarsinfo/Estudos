//importando modulos
const http = require('http')
const formidable = require('formidable');
const fs = require('fs');
//rede servidor
const port = process.env.PORT || 3000
const hostname = '127.0.0.1'
const retorno = () => {console.log('servidor aula 12 rodando')}
//servidor

const servidor = http.createServer((req,res) => {   

    if (req.url == '/envioDeArquivo') {
        const formulario = new formidable.IncomingForm();
        formulario.parse(req , (erro, campos, arquivos) => {
            const urlAntiga = arquivos.filetoupload.filepath
            const urlNova = 'C:/Users/USER/Pictures/' + arquivos.filetoupload.originalFilename
            fs.rename(urlAntiga,urlNova, (erro) => {
                if (erro) throw erro 
                
                res.write('Arquivo movido')
                res.end()
            })
        })
    }
    else {
        res.writeHead(200,{'Content-Type':'text/html'})
        res.write('<form action="envioDeArquivo" method="post" enctype="multipart/form-data">')
        res.write('<input type="file" name="filetoupload"> <br> ')
        res.write('<input type="submit" value="Enviar"> ')
        res.write('</form>')   
        return res.end()

    }
    
    
})
servidor.listen(port,hostname,retorno)