#include <iostream>
#include <stdio.h>//arquivo de cabeçalho de C
    /*Aula 40 Comandos de C*/

using namespace std;

int main()
{
    int num1 = 123;
    int num2 = 124;
    int num3 = 125;
    char nome[10];
    
    scanf("%d %s", &num1,&nome);//&endereço
    printf("Valor da variavel num1: %d %d %d \n", num1, num2, num3);
    printf("Valor da variavel num1: %d %s \n", num1, nome);    
    printf("\nSaraiva \n Estudos\0 Termina a string");
    
    return 0;
}

/*
d,i => int
x, X => Hexadecimal
u => inteiro sem sinal
s => string, char*
f => double
p => ponteiro
*/