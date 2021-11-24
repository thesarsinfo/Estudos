# Crie sua classe Morador aqui

class Apartamento():
    '''
    Cria a representação de um apartamento
    '''
    def __init__(self, n_apto, n_andar):
        
        self.lista_objeto_moradores = []
        self.lista_nome_moradores = []
        self.n_apto = n_apto
        self.n_andar = n_andar
        self.__voto = 0
        self.__voter_nome = ''
    
    def incluir_morador(self, nome_morador):
        
        self.lista_objeto_moradores.append(nome_morador)
        self.lista_nome_moradores.append(nome_morador.nome)
        
    
    def __repr__(self):
        return f"Apartamento {self.n_apto}\n{self.n_andar}º andar\nMoradores: {self.lista_nome_moradores}"
    
    
    def voto_checker(self, nome_morador, n_apto, n_candidato):
        if self.__voto == 0:
            self.__voto = n_candidato
            self.voter_nome = nome_morador
            #appendar n_apto na Urna
            #appendar nome_morador na Urna
            #appendar n_candidato na urna
            
            return 'Voto computado com sucesso.'
        else:
            if nome_morador in self.lista_nome_moradores:
                return f'{nome_morador} já votou'

class Morador(Apartamento):
    '''
    Cria um morador do condominio
    apto a votar
    '''
    def __init__(self, nome_morador, n_apto, n_andar):
        super().__init__(n_apto, n_andar)
        '''
        Construtor
        
        Parâmetros:
        -----------
        nome_morador: str
            nome associado ao morador 
        
        '''
#         Construtores que não estão nos parâmetros
#         -----------------------------------------
#         voto : int
#            voto no candidato escolhido
#            e que será inserido na urna
        '''
        
        '''
        self.nome = nome_morador
        self.n_candidato = 0
        
        
    
    def __repr__(self):
        return f"Nome: {self.nome}\nApto: {self.n_apto}\n{self.n_andar} andar"
        
        
    def voto_urna(self, n_candidato, n_apto):
         '''
        Verifica se o voto de seu apartamento já foi computado e,
        caso não tenha, ela irá chamar o método de addicionar voto na Urna,
        através do número de candidato e irá computar o voto do apartamento.
        
        Parâmetros
        ----------
        n_candidato : int
            numero do candidado que recebeu o voto
                                
        '''
        
#       if self.n_apto in #Urna.LISTA_AP_JA_VOTOU?:
#             f'Já foi computado voto deste apartamento'
#         else:
#             n_candidato.append(#Urna.LISTA_VOTO)
#             n_apto.append(#Urna.LISTA_AP_JA_VOTOU?)    

# Crie sua classe Candidato aqui

class Candidato(Morador):
    '''
    Cria um Candidato, é morador do condominio
    apto a votar. Possui atributos adicionais
    que o definem como Candidato
    '''
    def __init__(self, nome_morador, n_apto, id_candidato=0,cont_voto=0):
        super().__init__(nome_morador, n_apto)
        
        self.id_candidato = id_candidato
        self.cont_voto = cont_voto
        
    def id_candidato(self, id_candidato):
        return id_candidato

# Crie sua classe Urna

class Urna(Candidato):
    def __init__(self, nome_morador, n_apto, id_candidato=0, cont_voto=0):
        super().__init__(nome_morador, n_apto, id_candidato=id_candidato, cont_voto=cont_voto)


# 
print("Programa iniciado")
# Cadastro de morador
nome_morador = input("digite o nome do morador: ")
n_apto = input("digite o apto morador: ")
n_andar = input("digite o andar: ")

# Inserção do morador
morador = Morador(nome_morador,n_apto,n_andar)
listaMoradores = Apartamento(n_apto,n_andar)
listaMoradores.incluir_morador(morador)
print(morador)
# verifando o moradores apartamento

print(listaMoradores)




