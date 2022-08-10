num = eval(input('Digite um número:'))
funcao = input('Digite quadrado ou cubo:') 
if funcao == 'quadrado':
    num=num*num 
    print(num) 
else: 
    num=num*num*num 
    print(num)
#E você quer fazer uma função que calcule o quadrado do número, assim você a chama no programa desta maneira: 

num = eval(input('Digite um número:')) 
funcao = input('Digite quadrado ou cubo:') 
if funcao == 'quadrado': 
    print(calculaQuadrado(num)) 
else: 
    print(num* calculaQuadrado(num))


import math 
num = input("Digite um número: ") 
quadrado = math.pow(num, 2) 
cubo = math.pow(num, 3) 
raiz = math.sqrt(num) 
print(f'O numero ao quadrado é {quadrado} e ao cubo é {cubo}') 
print(f'A raiz quadrada é {raiz:.2f}')

base = eval(input("base"))
altura = eval(input("altura"))
print((base * altura) / 2)
