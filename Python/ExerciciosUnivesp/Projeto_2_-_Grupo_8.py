{
 "cells": [
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "# Organizando uma eleição\n",
    "(créditos ao professor Rafael)"
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "O último ano foi extremamente desafiador para você. Além de estarmos vivendo uma pandemia que aumentou nossa preocupação com a nossa própria vida e com nossos entes queridos e estarmos obrigados a passar mais tempo em casa para garantir nossa segurança, você se matriculou em um curso de programação e ciência de dados para mudar de rumo em sua carreira!\n",
    "\n",
    "O _timing_ pareceu ideal: mais tempo em casa, mais tempo para estudar. Porém, você esbarrou em algumas dificuldades. O condomínio está em reforma, e você passa o dia ao som de marretadas no piso. Durante a noite, no horário da sua aula online, seus vizinhos - um casal passando por dificuldades na relação - costumam discutir em voz alta. A discussão deles frequentemente acorda o bebê do outro vizinho e todos os cachorros do andar no prédio. Deixar para estudar no final de semana não ajuda, pois o filho adolescente da família do apartamento logo acima do seu costuma trazer os colegas de banda para ensaiar. \n",
    "\n",
    "A situação se tornou insustentável, e o síndico - que é o mesmo senhorzinho desde que você se mudou para esse condomínio, há mais de 10 anos - não toma atitudes e não gosta de ser perturbado. Chegou a hora de organizar uma eleição para um novo síndico, e você tomou a iniciativa de montar um sistema eletrônico para auxiliar na votação."
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "## Entidades envolvidas\n",
    "\n",
    "Podemos imaginar as seguintes entidades envolvidas na eleição:\n",
    "\n",
    "* **Morador**: representa cada uma das pessoas que moram no prédio. Possui um nome, um Apartamento e é capaz de depositar um voto em um Candidato em uma Urna.\n",
    "* **Candidato**: é um tipo especial de Morador. Possui tudo o que o morador possui, mas também possui um número que será usado para representá-lo na Urna e uma contagem individual de votos.\n",
    "* **Apartamento**: representa cada uma das unidades do prédio. Possui uma lista de moradores e um status indicando se ele já votou ou não. Cada apartamento tem direito a exatamente 1 voto. Se a sua filha já votou, você não pode mais votar!\n",
    "* **Urna**: coleciona votos. Ela possui uma coleção de candidatos e uma coleção de moradores (lembrando que o candidato também conta como morador!). Ela armazena a quantidade de votos de cada candidato e é capaz de incrementar essa quantidade ao receber um voto novo. Ela também possui uma coleção de apartamentos e é capaz de determinar quais apartamentos já votaram (mas não qual apartamento votou em cada candidato - o voto é secreto). Quando o último apartamento votar, ela publica os resultados e declara o vencedor.\n",
    "\n",
    "Vamos pensar juntos em meios de implementar cada uma das classes."
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "### Morador\n",
    "\n",
    "A classe mais básica de nossa eleição, representando cada uma das pessoas que habitam no condomínio. O morador obrigatoriamente possui um nome e um Apartamento.\n",
    "\n",
    "Seu construtor pode ou não receber uma string contendo o nome, e pode ou não receber um objeto Apartamento. Caso ele não receba um nome, deverá solicitar a digitação de um através do input. Caso ele não receba um objeto Apartamento, deverá pedir por input o número do apartamento e criar o objeto.\n",
    "\n",
    "O nome e apartamento digitados ou recebidos deverão se tornar atributos do objeto.\n",
    "\n",
    "Nosso objeto também deverá possuir um método para votar. Ele deverá receber um objeto Urna e pode receber um número inteiro correspondente ao número de um candidato ou, caso não receba, irá ler o número pelo teclado. Ela deverá primeiro verificar se o seu apartamento já votou, e caso não tenha, ela irá chamar o método de acrescentar voto na Urna, informando o número de seu candidato e passando seu objeto apartamento. Caso contrário, ela exibirá uma mensagem alertando que esse apartamento já votou."
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 53,
   "metadata": {},
   "outputs": [],
   "source": [
    "# Crie sua classe Morador aqui\n",
    "\n",
    "class Morador(Apartamento):\n",
    "    '''\n",
    "    Cria um morador do condominio\n",
    "    apto a votar\n",
    "    '''\n",
    "    def __init__(self, nome_morador, n_apto, n_andar):\n",
    "        super().__init__(n_apto, n_andar)\n",
    "        '''\n",
    "        Construtor\n",
    "        \n",
    "        Parâmetros:\n",
    "        -----------\n",
    "        nome_morador: str\n",
    "            nome associado ao morador \n",
    "        \n",
    "        '''\n",
    "#         Construtores que não estão nos parâmetros\n",
    "#         -----------------------------------------\n",
    "#         voto : int\n",
    "#            voto no candidato escolhido\n",
    "#            e que será inserido na urna\n",
    "        '''\n",
    "        \n",
    "        '''\n",
    "        self.nome = nome_morador\n",
    "        self.n_candidato = 0\n",
    "        \n",
    "        \n",
    "    \n",
    "    \n",
    "        \n",
    "        \n",
    "    def voto_urna(self, n_candidato, n_apto):\n",
    "         '''\n",
    "        Verifica se o voto de seu apartamento já foi computado e,\n",
    "        caso não tenha, ela irá chamar o método de addicionar voto na Urna,\n",
    "        através do número de candidato e irá computar o voto do apartamento.\n",
    "        \n",
    "        Parâmetros\n",
    "        ----------\n",
    "        n_candidato : int\n",
    "            numero do candidado que recebeu o voto\n",
    "                                \n",
    "        '''\n",
    "        \n",
    "#         if self.n_apto in #Urna.LISTA_AP_JA_VOTOU?:\n",
    "#             f'Já foi computado voto deste apartamento'\n",
    "#         else:\n",
    "#             n_candidato.append(#Urna.LISTA_VOTO)\n",
    "#             n_apto.append(#Urna.LISTA_AP_JA_VOTOU?)    \n",
    "            "
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 54,
   "metadata": {},
   "outputs": [],
   "source": [
    "paulo = Morador('Paulo', 60,6)\n",
    "bruna = Morador('Bruna', 60,6)"
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "### Candidato\n",
    "\n",
    "Objetos da classe Candidato são, necessariamente, moradores. Eles possuem as mesmas informações e as mesmas ações que um morador. O que isso significa em programação orientada a objeto?\n",
    "\n",
    "Ele possui outros dois atributos: o seu número que será usado para identificá-lo na Urna e sua contagem de votos. Ambos devem ser inicializados com valor 0. \n",
    "\n",
    "Ele deve oferecer métodos para que seu número seja configurado (quando cadastrarmos o candidato na Urna, ela irá fornecer um número para ele), bem como para que sua contagem de votos seja atualizada (ao final da votação, a Urna irá atualizar a contagem de todos os candidatos)."
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 2,
   "metadata": {},
   "outputs": [],
   "source": [
    "# Crie sua classe Candidato aqui\n",
    "\n",
    "class Candidato(Morador):\n",
    "    '''\n",
    "    Cria um Candidato, é morador do condominio\n",
    "    apto a votar. Possui atributos adicionais\n",
    "    que o definem como Candidato\n",
    "    '''\n",
    "    def __init__(self, nome_morador, n_apto, id_candidato=0,cont_voto=0):\n",
    "        super().(self, nome_morador, n_apto)\n",
    "        \n",
    "        self.id_candidato = #URNA.id_candidato\n",
    "        self.cont_voto = #URNA.cont_voto\n",
    "        \n",
    "    def id_candidato(self,)"
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "### Apartamento\n",
    "\n",
    "Objetos da classe Apartamento irão agregar objetos Morador. Isso significa que um de seus atributos será uma lista de moradores. Quando um Apartamento é criado, sua lista começará vazia. O Apartamento deve oferecer métodos para adicionar moradores novos (recebe um objeto Morador e adiciona à lista) e para visualizar seus moradores.\n",
    "\n",
    "Cada apartamento tem direito a exatamente um voto na eleição para síndico. Portanto, cada objeto também deve ter um atributo indicando se aquele apartamento já votou ou não. A classe deve fornecer meios para que a esse atributo possa ser atualizado, pois quando um morador votar, a urna irá alterar esse atributo registrando que o apartamento já votou."
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 55,
   "metadata": {},
   "outputs": [],
   "source": [
    "# Crie sua classe Apartamento aqui\n",
    "\n",
    "class Apartamento():\n",
    "    '''\n",
    "    Cria a representação de um apartamento\n",
    "    '''\n",
    "    def __init__(self, n_apto, n_andar):\n",
    "        \n",
    "        self.lista_objeto_moradores = []\n",
    "        self.lista_nome_moradores = []\n",
    "        self.n_apto = n_apto\n",
    "        self.n_andar = n_andar\n",
    "        self.__voto = 0\n",
    "        self.__voter_nome = ''\n",
    "    \n",
    "    def incluir_morador(self, nome_morador):\n",
    "        \n",
    "        self.lista_objeto_moradores.append(nome_morador)\n",
    "        self.lista_nome_moradores.append(nome_morador.nome)\n",
    "        \n",
    "    \n",
    "    def __repr__(self):\n",
    "        return f\"Apartamento {self.n_apto}\\n{self.n_andar}º andar\\nMoradores: {self.lista_nome_moradores}\"\n",
    "    \n",
    "    \n",
    "    def voto_checker(self, nome_morador, n_apto, n_candidato):\n",
    "        if self.__voto == 0:\n",
    "            self.__voto = n_cadidato\n",
    "            self.voter_nome = nome_morador\n",
    "            #appendar n_apto na Urna\n",
    "            #appendar nome_morador na Urna\n",
    "            #appendar n_candidato na urna\n",
    "            \n",
    "            return 'Voto computado com sucesso.'\n",
    "        else:\n",
    "            if nome_morador in self.lista_nome_moradores:\n",
    "                return f'{nome_morador} já votou'"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 56,
   "metadata": {},
   "outputs": [],
   "source": [
    "apto1 = Apartamento(\n",
    "    60,\n",
    "    6)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 57,
   "metadata": {},
   "outputs": [],
   "source": [
    "apto1.incluir_morador(paulo)\n",
    "apto1.incluir_morador(bruna)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 59,
   "metadata": {},
   "outputs": [
    {
     "ename": "NameError",
     "evalue": "name 'n_cadidato' is not defined",
     "output_type": "error",
     "traceback": [
      "\u001b[1;31m---------------------------------------------------------------------------\u001b[0m",
      "\u001b[1;31mNameError\u001b[0m                                 Traceback (most recent call last)",
      "\u001b[1;32m<ipython-input-59-8ca00a4e3355>\u001b[0m in \u001b[0;36m<module>\u001b[1;34m\u001b[0m\n\u001b[1;32m----> 1\u001b[1;33m \u001b[0mapto1\u001b[0m\u001b[1;33m.\u001b[0m\u001b[0mvoto_checker\u001b[0m\u001b[1;33m(\u001b[0m\u001b[0mbruna\u001b[0m\u001b[1;33m,\u001b[0m\u001b[1;36m6\u001b[0m\u001b[1;33m,\u001b[0m\u001b[1;36m15\u001b[0m\u001b[1;33m)\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[0m\n\u001b[0m",
      "\u001b[1;32m<ipython-input-55-af4e58d4141b>\u001b[0m in \u001b[0;36mvoto_checker\u001b[1;34m(self, nome_morador, n_apto, n_candidato)\u001b[0m\n\u001b[0;32m     26\u001b[0m     \u001b[1;32mdef\u001b[0m \u001b[0mvoto_checker\u001b[0m\u001b[1;33m(\u001b[0m\u001b[0mself\u001b[0m\u001b[1;33m,\u001b[0m \u001b[0mnome_morador\u001b[0m\u001b[1;33m,\u001b[0m \u001b[0mn_apto\u001b[0m\u001b[1;33m,\u001b[0m \u001b[0mn_candidato\u001b[0m\u001b[1;33m)\u001b[0m\u001b[1;33m:\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[0m\n\u001b[0;32m     27\u001b[0m         \u001b[1;32mif\u001b[0m \u001b[0mself\u001b[0m\u001b[1;33m.\u001b[0m\u001b[0m__voto\u001b[0m \u001b[1;33m==\u001b[0m \u001b[1;36m0\u001b[0m\u001b[1;33m:\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[0m\n\u001b[1;32m---> 28\u001b[1;33m             \u001b[0mself\u001b[0m\u001b[1;33m.\u001b[0m\u001b[0m__voto\u001b[0m \u001b[1;33m=\u001b[0m \u001b[0mn_cadidato\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[0m\n\u001b[0m\u001b[0;32m     29\u001b[0m             \u001b[0mself\u001b[0m\u001b[1;33m.\u001b[0m\u001b[0mvoter_nome\u001b[0m \u001b[1;33m=\u001b[0m \u001b[0mnome_morador\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[0m\n\u001b[0;32m     30\u001b[0m             \u001b[1;31m#appendar n_apto na Urna\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[1;33m\u001b[0m\u001b[0m\n",
      "\u001b[1;31mNameError\u001b[0m: name 'n_cadidato' is not defined"
     ]
    }
   ],
   "source": [
    "apto1.voto_checker(bruna,6,15)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "metadata": {},
   "outputs": [],
   "source": []
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "metadata": {},
   "outputs": [],
   "source": []
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "metadata": {},
   "outputs": [],
   "source": []
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "### Urna\n",
    "A classe mais complexa do projeto. Ela é responsável por boa parte da lógica da nossa eleição.\n",
    "\n",
    "Seu construtor deverá criar como atributos uma coleção de apartamentos e outra de candidatos - escolha a estrutura de dados que julgar mais adequada.\n",
    "\n",
    "A classe deve fornecer métodos que permitam o cadastro de apartamentos (recebendo como parâmetro objetos Apartamento já existentes) e candidatos (idem). Ao receber um candidato para cadastro, ela deverá gerar um número **único** para representar esse candidato na eleição e irá ajustar esse atributo diretamente no objeto candidato.\n",
    "\n",
    "Ela também deve ter um método para receber um voto, que deve receber um objeto apartamento e o número de um candidato. Ela deve atualizar a contagem de voto do candidato cujo número foi recebido, e marcar aquele apartamento como já votado. Se o apartamento que votou era o último que ainda podia votar, a urna deve imediatamente imprimir os resultados.\n",
    "\n",
    "Bole uma maneira que a urna possa sinalizar para o programa principal se ela já encerrou a votação ou não."
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 5,
   "metadata": {},
   "outputs": [],
   "source": [
    "# Crie sua classe Urna aqui\n",
    "\n",
    "class Urna:\n",
    "    '''\n",
    "    Cria a nossa Urna Eletronica\n",
    "    que irá garantir a ordem democrática condominial\n",
    "    '''\n",
    "    def __init__(self):\n",
    "        \n",
    "        self.list_apartamentos_total = []\n",
    "        self.list_candidatos = []\n",
    "        self.list_voters = []\n",
    "        self.list_aptos_votos = []\n",
    "        \n",
    "    def cadastro_aptos(self, nome_morador, n_apto):\n",
    "        if n_apto in self.list_aptos_votos:\n",
    "            return f'Já foi computado um voto do apartamento {n_apto} pelo morador {self.list_voters[self.list_aptos_votos.index(n_apto)]}'\n",
    "        return self.list_voters.append(nome_morador),self.list_aptos_votos.append(n_apto)\n",
    "            \n",
    "            \n",
    "        \n",
    "        \n",
    "        \n",
    "        "
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 8,
   "metadata": {},
   "outputs": [
    {
     "name": "stdout",
     "output_type": "stream",
     "text": [
      "Alessandro\n"
     ]
    }
   ],
   "source": [
    "nomes = ['Paulo', 'Alessandro', 'Denner', 'Xablau']\n",
    "aptos = [3,7,3,8]\n",
    "\n",
    "n_apto = 7\n",
    "aptos.index(n_apto)\n",
    "if n_apto in aptos:\n",
    "    print(nomes[aptos.index(n_apto)])\n",
    "\n",
    "urna1 = Urna()"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 9,
   "metadata": {},
   "outputs": [
    {
     "data": {
      "text/plain": [
       "(None, None)"
      ]
     },
     "execution_count": 9,
     "metadata": {},
     "output_type": "execute_result"
    }
   ],
   "source": [
    "urna1.cadastro_aptos('Vieira', 9)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "metadata": {},
   "outputs": [],
   "source": []
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "## O programa principal\n",
    "\n",
    "Seu programa principal terá 3 etapas - fique à vontade para modularizar essas etapas com o auxílio de funções, ou mesmo utilizar outras classes se julgar necessário.\n",
    "\n",
    "* Cadastro: o programa deverá ler informações sobre cada pessoa e ir criando os objetos Morador/Candidato e Apartamento correspondentes. Lembre-se de sempre perguntar se a próxima pessoa a ser lida é ou não candidata para decidir a melhor forma de instanciá-la no sistema.\n",
    "\n",
    "* Configuração: o programa deverá utilizar as informações obtidasna etapa anterior para criar uma urna.\n",
    "\n",
    "* Votação: o programa ficará em loop permitindo que diferentes moradores votem (ou tentem votar). Nessa etapa, o programa deve ser capaz de identificar qual o morador votando e utilizar os métodos criados previamente para realizar o voto. Quando a classe Urna informar que a votação acabou, o loop deve ser encerrado."
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 5,
   "metadata": {},
   "outputs": [],
   "source": [
    "## crie o programa principal aqui"
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "## Dicas\n",
    "\n",
    "* Métodos mágicos: no mínimo uma _representação imprimível_ dos objetos de cada classe seria desejável para facilitar a sua vida. No caso de um morador, podemos imprimir seu nome e número do apartamento. No caso de um candidato, poderíamos incluir o número da urna. No caso do apartamento, seria legal imprimir todos os moradores. E no caso da urna, podemos ter dois casos: antes da votação acabar, apenas a lista de apartamentos que já votou deveria ser impressa. Após o término da votação, ela deveria imprimir quantos votos cada candidato recebeu e qual deles venceu.\n",
    "\n",
    "* Arquivos e testes: note que vocês sempre foram orientados a passar dados por parâmetros **ou** digitá-los. Se você bolar um esquema inteligente com arquivos em formato padronizado (como CSV) e organizar direitinho seu programa principal, você consegue gerar um único arquivo com todos os moradores e suas respectivas informações (número do apartamento, se é ou não candidato e em quem gostaria de votar) e automatizar completamente as etapas do seu programa.\n",
    "\n",
    "* Segurança adicional: atualmente, cada apartamento armazena a informação se já votou ou não. Mas e se o apartamento pudesse alterar essa informação e enganar a urna? Você pode colocar uma camada redundante de segurança fazendo com que a urna TAMBÉM controle quais apartamentos já votaram. Mesmo que o apartamento diga que não votou, se a urna está registrando que ele votou, então um hipotético segundo voto deve ser recusado. Veja se consegue pensar em outras possíveis falhas de segurança em potencial no programa. Lembre-se sempre de pensar do ponto de vista de uma classe e \"desconfiar\" das outras.\n",
    "\n",
    "* Criatividade: os enunciados trazem o **mínimo** que você precisa fazer para que o seu programa funcione como foi planejado. Isso não impede que você crie outros métodos, acrescente informações que possam ser úteis e até mesmo crie outras classes para modelar melhor outros fatores que poderiam ser considerados na organização da sua eleição.\n"
   ]
  },
  {
   "cell_type": "markdown",
   "metadata": {},
   "source": [
    "## Bônus: representação visual dos votos\n",
    "\n",
    "A função abaixo gera um gráfico de barras mostrando quantos votos cada candidato teve! Cole-a em sua classe Urna e faça os devidos ajustes para que ela use os atributos da Urna ao invés dos parâmetros utilizados. \n",
    "\n",
    "O programinha na célula seguinte apenas ilustra o funcionamento da função.\n"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 6,
   "metadata": {},
   "outputs": [],
   "source": [
    "import matplotlib.pyplot as plt\n",
    "\n",
    "def graficoVotos(candidatos, votos):\n",
    "    plt.bar(candidatos, votos)\n",
    "    plt.title('Resultado das eleições')\n",
    "    plt.xlabel('Candidatos')\n",
    "    plt.ylabel('Votos')\n",
    "    "
   ]
  },
  {
   "cell_type": "code",
   "execution_count": 7,
   "metadata": {},
   "outputs": [
    {
     "data": {
      "image/png": "iVBORw0KGgoAAAANSUhEUgAAAXgAAAEWCAYAAABsY4yMAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAALEgAACxIB0t1+/AAAADh0RVh0U29mdHdhcmUAbWF0cGxvdGxpYiB2ZXJzaW9uMy4xLjMsIGh0dHA6Ly9tYXRwbG90bGliLm9yZy+AADFEAAAZhElEQVR4nO3de5hcVZ3u8e+bCxAgECEtNwlBAvgAzxCgAVGuchdUUOdRYDyEOcccZvQEFC+IjOAZcIKiBx2Z0SgXB7koDCiCIuCIyMjFTogQCCiXACEBmkAk4U78nT/WKlPdqeou0r2rO6vfz/PUk6q9195rVe3OW6tW1V5bEYGZmZVn1FA3wMzMquGANzMrlAPezKxQDngzs0I54M3MCuWANzMrlAPehg1J+0taOIj7mybptkHa18WSzhqMfbVY32RJIWlMC2WPk3Rji/udKekRSdtJunngLbXhzAFvDUlaIOllScslPZUDbv0haMNB7axzTRQRl0bEIS0W3xZ4L/A94KbqWmXDgQPe+vK+iFgfmArsAnxhiNtjAxQRH4qIByJiv4g4Z6jbY9VywFu/IuIp4JekoAdA0tqSzpX0uKSnJX1H0ri8bqKk6yQtlfScpN9KGpXXhaQpdftpOPQh6RJgEvCz/Cnic3n5lfkTxZ8l3Sppx7ptNpZ0raQXJN0FbNNrn++S9Pu87e8lvavZc5a0i6Q5kpZJ+hGwTt26t+Tn1y3p+Xz/bXXrp+VhkGWSHpV0XJM6Rkk6VdLDkpZI+rGkjZqU3VDSBZIWS3pS0lmSRtfVd1td2R0l3ZRf+6clnVZ3zM6TtCjfzpO0dt12R0qam4/b7yT9Td26z+d6l0l6UNKBzV47Gz4c8NavHF6HAw/VLT4H2I4U+lOALYAv5XWnAAuBDmAT4DTgTc2JEREfAx4nf4qIiK/mVb8gDTO8FZgDXFq32fnAK8BmwN/nW+05bARcD3wL2Bj4BnC9pI0bPN+1gJ8AlwAbAVcCH6orMgq4CNiK9Cb0MvDtvO16uY7DI2I88C5gbpOnOQM4CtgP2Bx4Pj+HRn4AvEF6rXcBDgH+V4O2jwduBm7I+5wC/Cqv/iLwTtIx2xnYAzg9b7crcCHwv/Pr813g2vymsD3wSWD3/JwOBRY0aacNJxHhm2+r3Ej/gZcDy0jh/CtgQl4n4EVgm7ryewGP5vv/F/gpMKXBfqN+OXAxcFa+vz+wsFcbDuqjjRPy/jYERgOvA++oW/8V4LZ8/2PAXb22vx2Y1mC/+wKLANUt+12tnQ3KTwWez/fXA5aS3hDG9fMazwcOrHu8WX4OY4DJ+bmNIb1Jvlq/P+AY4Nf5/rS653kMcHeT+h4G3lv3+FBgQb7/78A/9yr/IOnNZwrwDHAQMHao/zZ9a/3mHrz15ahIPbb9gXcAE/PyDmBdYHb+OL+U1GPsyOu/Rurt35iHKk4djMZIGp1/BfKwpBdY2YucmOseAzxRt8ljdfc37/W4tn6LBlVtDjwZOeV670vSupK+K+mx3I5bgQmSRkfEi8BHgBOBxZKul/SOJk9pK+CautdwPrCCFOi9y43N+6uV/S7pU0xvW5KCvJHer8FjeVmtjlNq+891bAlsHhEPAScDZwLPSLpC0ubYsOeAt35FxG9IPe1z86JnScMSO0bEhHzbMNIXskTEsog4JSLeDrwP+HTdmO1LpDeHmk37qrrX42OBD5B6khuSermQPlF0k4YwtqwrP6nu/iJSiNFr/ZMN6l0MbCFJTfZ1CrA9sGdEbEDq8dfaQUT8MiIOJvXIHyD9YqWRJ0hDORPqbutERO82PUHqwU+sK7dBROy46i55gl7fPdTp/RpMystq253dqy3rRsTl+TldFhF75+2DNERnw5wD3lp1HnCwpKkR8RdSaP0/SW8FkLSFpEPz/SMlTckB+QKpV7oi72cucGzujR9GGgJo5mng7XWPx5OCbgnpTeIrtRURsQK4Gjgz97B3AI6v2/bnwHaSjpU0RtJHgB2A6xrUezvpzWJGLvtB0nh1fTteBpbmsf0zaiskbSLp/Xks/lXSMNcKGvsOcLakrfK2HZI+0LtQRCwGbgS+LmmD/OXsNpIavXbXAZtKOjmPn4+XtGdedzlweq5nIuk7kx/mdd8DTpS0p5L1JB2Rt99e0nvyF7Kv5Ofe7DnZMOKAt5ZERDfwH8A/5UWfJw3D3JGHKW4m9WohfQl6Myncbgf+LSJuyetOIvXqlwLHkb7MbOZfSIG0VNJncv2PkXrd9wN39Cr/SWB94CnSJ46L6tq/BDiS1PteAnwOODIinm3wXF8DPkga236eNORydV2R84BxpE8yd5CGp2pG5ToWAc+R3sD+scnz+yZwLWkoa1ne155Nyv4PYK38vJ8HriJ9Qujd9mXAwaTX+BXSa3VAXn0W0AXcA9xL+pL6rLxdF/Bx0pfFz5OO7bS83drAzPx8nyINDZ3WpJ02jKjnMKOZlULSPsAhEfFP/Ra2IrkHb1YgpbOOH2dl791GIAe8WZm+TBrOafQdg40QHqIxMyuUe/BmZoXqdyrSdpo4cWJMnjx5qJthZrbGmD179rMR0dFo3bAK+MmTJ9PV1TXUzTAzW2NI6n2G9l95iMbMrFAOeDOzQjngzcwK5YA3MyuUA97MrFAOeDOzQlUa8JI+Jek+SfMkXS5pnf63MjOzwVBZwEvagnTNyc6I2Il0SbWPVlWfmZn1VPUQzRhgnKQxpAs0LOqnvJmZDZLKzmSNiCclnUuasvRl4MaIuLF3OUnTgekAkyZN6r26ZZNPvX61t7W+LZh5xFA3wcxWQ5VDNG8hXT9za9KFfdeT9He9y0XErIjojIjOjo6G0ymYmdlqqHKI5iDg0YjojojXSZc8e1eF9ZmZWZ0qA/5x4J35AsgCDgTmV1ifmZnVqSzgI+JO0oWB55Au8DsKmFVVfWZm1lOl0wVHxBnAGVXWYWZmjflMVjOzQjngzcwK5YA3MyuUA97MrFAOeDOzQjngzcwK5YA3MyuUA97MrFAOeDOzQjngzcwK5YA3MyuUA97MrFAOeDOzQjngzcwK5YA3MyuUA97MrFBVXnR7e0lz624vSDq5qvrMzKynyq7oFBEPAlMBJI0GngSuqao+MzPrqV1DNAcCD0fEY22qz8xsxGtXwH8UuLxNdZmZGW0IeElrAe8HrmyyfrqkLkld3d3dVTfHzGzEaEcP/nBgTkQ83WhlRMyKiM6I6Ozo6GhDc8zMRoZ2BPwxeHjGzKztKg14SesCBwNXV1mPmZmtqrKfSQJExEvAxlXWYWZmjflMVjOzQjngzcwK5YA3MyuUA97MrFAOeDOzQjngzcwK5YA3MyuUA97MrFAOeDOzQjngzcwK5YA3MyuUA97MrFAOeDOzQjngzcwK5YA3MyuUA97MrFAOeDOzQlV9yb4Jkq6S9ICk+ZL2qrI+MzNbqdJL9gHfBG6IiA9LWgtYt+L6zMwsqyzgJW0A7AtMA4iI14DXqqrPzMx6qnKI5u1AN3CRpLslfV/Ser0LSZouqUtSV3d3d4XNMTMbWaoM+DHArsC/R8QuwIvAqb0LRcSsiOiMiM6Ojo4Km2NmNrJUGfALgYURcWd+fBUp8M3MrA0qC/iIeAp4QtL2edGBwP1V1WdmZj1V/Sua/wNcmn9B8whwQsX1mZlZVmnAR8RcoLPKOszMrDGfyWpmVigHvJlZoRzwZmaFcsCbmRXKAW9mVigHvJlZoRzwZmaFcsCbmRXKAW9mVigHvJlZoRzwZmaFcsCbmRXKAW9mVigHvJlZoRzwZmaFcsCbmRXKAW9mVqhKr+gkaQGwDFgBvBERvrqTmVmbVH1NVoADIuLZNtRjZmZ1PERjZlaoqgM+gBslzZY0vVEBSdMldUnq6u7urrg5ZmYjR9UB/+6I2BU4HPiEpH17F4iIWRHRGRGdHR0dFTfHzGzkqDTgI2JR/vcZ4BpgjyrrMzOzlSoLeEnrSRpfuw8cAsyrqj4zM+upyl/RbAJcI6lWz2URcUOF9ZmZWZ3KAj4iHgF2rmr/ZmbWN/9M0sysUA54M7NCOeDNzArlgDczK1S/AS9pG0lr5/v7S5ohaUL1TTMzs4FopQf/n8AKSVOAC4CtgcsqbZWZmQ1YKwH/l4h4AzgaOC8iPgVsVm2zzMxsoFoJ+NclHQMcD1yXl42trklmZjYYWgn4E4C9gLMj4lFJWwM/rLZZZmY2UP0GfETcD3wGuFfSTsDCiJhZecvMzGxA+p2qQNL+wA+ABYCALSUdHxG3Vts0MzMbiFbmovk6cEhEPAggaTvgcmC3KhtmZmYD08oY/NhauANExB/xl6xmZsNeKz34LkkXAJfkx8cBs6trkpmZDYZWAv4fgE8AM0hj8LcC51fZKDMzG7hWAv7EiPgG8I3aAkknAd+srFVmZjZgrYzBH99g2bRBboeZmQ2ypj34fPbqscDWkq6tW7UBsKTVCiSNBrqAJyPiyNVtqJmZvTl9DdH8DlgMTCT9VLJmGXDPm6jjJGA+6Y3BzMzapOkQTUQ8FhG3RMRewAPA+HxbmCcf65ektwFHAN8fjMaamVnrWjmT9W+Bc4FbSL+i+VdJn42Iq1rY/3nA50hvDM32Px2YDjBp0qQWdmlmQ2HyqdcPdROKtWDmEZXst5Vf0ZwO7B4RzwBI6gBuBvoMeElHAs9ExOw83UFDETELmAXQ2dkZLbbbzMz60cqvaEbVwj1b0uJ27wbeL2kBcAXwHkmehdLMrE1a6cHfIOmXpPlnAD4C/Ly/jSLiC8AX4K8Tln0mIv5uNdtpZmZvUl8/k/w2cFlEfFbSB4G9SWPwsyLimnY10MzMVk9fPfg/AV+XtBnwI+A/ImLu6lQSEbeQvqQ1M7M26etnkt/MP5HcD3gOuEjSfElfylMGm5nZMNbKFZ0ei4hzImIX0pmtR5NOXDIzs2Gs34CXNFbS+yRdCvwC+CPwocpbZmZmA9LXl6wHA8eQzkS9i/RTx+kR8WKb2mZmZgPQ15espwGXkX7e+Fyb2mNmZoOkacBHxAHtbIiZmQ2uVs5INTOzNZAD3sysUA54M7NCOeDNzArlgDczK5QD3sysUA54M7NCOeDNzArlgDczK5QD3sysUA54M7NCVRbwktaRdJekP0i6T9KXq6rLzMxW1cpFt1fXq8B7ImK5pLHAbZJ+ERF3VFinmZlllQV8RASwPD8cm29RVX1mZtZTlT14JI0GZgNTgPMj4s4GZaYD0wEmTZpUZXNsGJl86vVD3YRiLZh5xFA3wYaJSr9kjYgVETEVeBuwh6SdGpSZFRGdEdHZ0dFRZXPMzEaUtvyKJiKWArcAh7WjPjMzq/ZXNB2SJuT744CDgAeqqs/MzHqqcgx+M+AHeRx+FPDjiLiuwvrMzKxOlb+iuQfYpar9m5lZ33wmq5lZoRzwZmaFcsCbmRXKAW9mVigHvJlZoRzwZmaFcsCbmRXKAW9mVigHvJlZoRzwZmaFcsCbmRXKAW9mVigHvJlZoRzwZmaFcsCbmRXKAW9mVigHvJlZoaq8JuuWkn4tab6k+ySdVFVdZma2qiqvyfoGcEpEzJE0Hpgt6aaIuL/COs3MLKusBx8RiyNiTr6/DJgPbFFVfWZm1lNbxuAlTSZdgPvOBuumS+qS1NXd3d2O5piZjQiVB7yk9YH/BE6OiBd6r4+IWRHRGRGdHR0dVTfHzGzEqDTgJY0lhfulEXF1lXWZmVlPVf6KRsAFwPyI+EZV9ZiZWWNV9uDfDXwMeI+kufn23grrMzOzOpX9TDIibgNU1f7NzKxvPpPVzKxQDngzs0I54M3MCuWANzMrlAPezKxQDngzs0I54M3MCuWANzMrlAPezKxQDngzs0I54M3MCuWANzMrlAPezKxQDngzs0I54M3MCuWANzMrlAPezKxQVV6T9UJJz0iaV1UdZmbWXJU9+IuBwyrcv5mZ9aGygI+IW4Hnqtq/mZn1bcjH4CVNl9Qlqau7u3uom2NmVowhD/iImBURnRHR2dHRMdTNMTMrxpAHvJmZVcMBb2ZWqCp/Jnk5cDuwvaSFkv5nVXWZmdmqxlS144g4pqp9m5lZ/zxEY2ZWKAe8mVmhHPBmZoVywJuZFcoBb2ZWKAe8mVmhHPBmZoVywJuZFcoBb2ZWKAe8mVmhHPBmZoVywJuZFcoBb2ZWKAe8mVmhHPBmZoVywJuZFcoBb2ZWqEoDXtJhkh6U9JCkU6usy8zMeqrymqyjgfOBw4EdgGMk7VBVfWZm1lOVPfg9gIci4pGIeA24AvhAhfWZmVmdyi66DWwBPFH3eCGwZ+9CkqYD0/PD5ZIerLBNw8VE4NmhbkSrdM5Qt2BYWGOOmY/XX42UY7ZVsxVVBrwaLItVFkTMAmZV2I5hR1JXRHQOdTusdT5max4fs2qHaBYCW9Y9fhuwqML6zMysTpUB/3tgW0lbS1oL+ChwbYX1mZlZncqGaCLiDUmfBH4JjAYujIj7qqpvDTOihqQK4WO25hnxx0wRqwyLm5lZAXwmq5lZoRzwZmaFcsCvBkkrJM2VNE/SlZLW7aPsZEnH1j2eJunb7WnpyCJp+SDv74uS7pN0Tz7eq5zH0ce2m0u6qp8yEyT948BbWr7ex7b2/ygfo7n5tqLu/gxJZ0oKSVPqtvtUXtaZHy+QNLHdz6ddHPCr5+WImBoROwGvASf2UXYycGwf620YkrQXcCSwa0T8DXAQPU/c62vbMRGxKCI+3E/RCYADfgAi4uz8f3EqK/9fTo2Ib+Ui95J+wVfzYeD+tjd0iDjgB+63wBRJ/yzppNpCSWdLmgHMBPbJvYpP5dWbS7pB0p8kfbVum2Mk3Zs/GZxTt3x53t8fJN0haZN2Pbk1jaT1Jf1K0pz8Wn4gLz+nvrece3enNCsPbAY8GxGvAkTEsxGxKG+7u6Tf5eNxl6TxuUd5paSfATfmT27zcvlpkn6aj/mDks7IdcwEtsl/G19r00s00vyEPEWKpLcDfwa6h7RF7RQRvr3JG7A8/zsG+CnwD6Se+py8fBTwMLAxsD9wXd2204BHgA2BdYDHSCeEbQ48DnTk/f4XcFTeJoD35ftfBU4f6tdgON6A5fm12yA/ngg8RDqrehfgN3Vl7wcm9VF+fWAu8Efg34D9cpm18vHbPT/eIO9jGunkvo3y8snAvLpjvjj/PYwD5gGd9WV86/fYrsjHo3Z7HPh27+Pf6/GZwGeAq4GdgC8CxwO3AJ25zAJg4lA/v6puVU5VULJxkubm+78FLoiI1yQtkbQLsAlwd0QskRrN2MCvIuLPAJLuJ80lsTFwS0R05+WXAvuSeiCvAdflbWcDB1f0vEog4CuS9gX+QpoTaZOIuFvSWyVtTnoTfT4iHpc0tkn5pyTtBuwDHAD8KE95PRtYHBG/B4iIFwDycb4pIp5r0q6bImJJLns1sDfp2FprXo40DAOkT0WkN8lWXEEapjkUOBA4YdBbN0w54FdPjz+2Ot8n9dY2BS7sY/tX6+6vIB2Hhu8E2euRuxt15a2x40gBvltEvC5pAemTEsBVpDHYTUn/6fssHxErSL29WyTdS+r9zaHBnErZi320q/c2PgGlfX4GfA3oiogXmnS6iuQx+MF1DXAYsDvpDF6AZcD4Fra9E9hP0sQ8l/4xwG8qaWXZNgSeyWF9AD1n2qv15D5MCvum5SVtL2nbum2nkobTHiB9h7J7LjdeUitvuAdL2kjSOOAo4L9p/W/DBiAiXgY+D5w91G1pN/cEB1Eepvk1sDT3/gDuAd6Q9AfgYuD5JtsulvQF4Nek3vzPI+KnbWh2EXLIvgpcCvxMUhdprPaBWpmIuE/SeODJiFicFzcrvz7wr5ImAG+Qxuan52P8kbxuHPAy6Rc2/bkNuASYAlwWEV253f+dv4z9RUR8dgAvgfUhIq7oY/U9kv6S7/84Ij7djja1g6cqGESSRpE+wv9tRPxpqNszkkjaGfheROwx1G3prTZeHBGfHOq22MjiIZpBonQ5wodIX6A63NtI0onA5cDpQ90Ws+HEPXgzs0K5B29mVigHvJlZoRzwZmaFcsDbGkvSppKukPSwpPsl/VzSdgPcZ/0cMp2SvtWkXL+zEEo6bSBtMRsoB7ytkZROR7yGNL3DNhGxA3AaaZqIQRERXRExYwC7cMDbkHLA25rqANIUDt+pLYiIucDdTWaTnCxpvqTvKc3xfmM+UQlJu+WZIW8HPlHbn6T9JV2X72+ct7lb0nepm1pC0k8kzc77nZ6XzSTPWZTnFULSp5VmCp0n6eS8bD1J1+f65+WTqMwGhQPe1lQ7kSb+6u0V4OiI2JX0JvB1rZx8ZFvg/IjYEVgKfCgvvwiYERF79VHfGcBtEbELcC1pJsqav4+I3UiTX82QtHFEnMrK+cmPyxOXnQDsCbwT+HiemO4wYFFE7Bzp+gI3vNkXwqwZB7yVpjab5D3AzeTZIfO6R3MvH9Kbw2RJGwITIqI2788lTfa7L/BDgIi4np5TTszIU1HcQZr6edtVN2dv4JqIeDEilpOmsN2HdEGKg5Tmq9+nNsuo2WBwwNua6j5gtwbL62eHnAo8zcrZJJvN4tnq2X6rlJO0P2kumr0iYmfg7rr6ehRtuMOIP5Kex73Av0j6UottMeuXA97WVP8FrC3p47UFeYbHrWg+m+QqImIp8GdJe+dFxzUpemttnaTDgbfk5RuS5pZ/SdI7SMMvNa/n+eZr2x8laV1J6wFHA7/N89O/FBE/BM4Fdm3lyZu1wrNJ2hopIkLS0cB5+UIcr5CuznMm8K1Gs0n24QTgQkkvsXKa596+DFwuaQ5pGufH8/IbgBPzkNCDpGGamlmkmQrn5HH4i4G78rrv54uQHAp8Lc9m+Drp6mBmg8Jz0ZiZFcpDNGZmhXLAm5kVygFvZlYoB7yZWaEc8GZmhXLAm5kVygFvZlao/w+2bMmvFutrrAAAAABJRU5ErkJggg==\n",
      "text/plain": [
       "<Figure size 432x288 with 1 Axes>"
      ]
     },
     "metadata": {
      "needs_background": "light"
     },
     "output_type": "display_data"
    }
   ],
   "source": [
    "candidatos = ['Python', 'JavaScript', 'HTML']\n",
    "votos = [8, 3, 4]\n",
    "\n",
    "graficoVotos(candidatos, votos)"
   ]
  },
  {
   "cell_type": "code",
   "execution_count": null,
   "metadata": {},
   "outputs": [],
   "source": []
  }
 ],
 "metadata": {
  "kernelspec": {
   "display_name": "Python 3",
   "language": "python",
   "name": "python3"
  },
  "language_info": {
   "codemirror_mode": {
    "name": "ipython",
    "version": 3
   },
   "file_extension": ".py",
   "mimetype": "text/x-python",
   "name": "python",
   "nbconvert_exporter": "python",
   "pygments_lexer": "ipython3",
   "version": "3.8.5"
  }
 },
 "nbformat": 4,
 "nbformat_minor": 4
}
