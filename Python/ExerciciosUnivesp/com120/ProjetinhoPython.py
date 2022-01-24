#gerenciamento de memoria
import os
caminho = os.getcwd()
linha = []

leitor = open(caminho + '/Python/ExerciciosUnivesp/com120/ProjetinhoPython.CSV','r',encoding="UTF-8")
conteudo = leitor.readlines()
leitor.close()
for elemento in range(len(conteudo)):
    conteudo[elemento] = conteudo[elemento].replace("R$","")
    conteudo[elemento] = conteudo[elemento].replace("\n","")
    conteudo[elemento] = conteudo[elemento].replace(",",".")
    linha.append(conteudo[elemento].split(";"))
print("---")  
print("\n")  
linha[1][0] = 1
print(linha[1][0])








 




