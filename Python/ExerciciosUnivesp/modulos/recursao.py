class Formulas_matematica:
    def __init__(self):
        pass
    def contador(self,entrada_numero,limitador):
        if limitador > entrada_numero:
            print(entrada_numero)
            self.contador(entrada_numero +1,limitador)
        
