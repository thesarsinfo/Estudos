
from importado import mensagemUm
import importadoDois as imp2
import math as m
mensagemUm()
imp2.mensagemTres("Ola um teste")
m.sqrt(4)
n = 0
def funcaorecursiva(n):
    
    if (n < 10):      
        print(n)  
        funcaorecursiva(n + 1)
funcaorecursiva(n)

