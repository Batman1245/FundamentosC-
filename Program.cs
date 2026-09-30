//////// cometario


///////*
////// * 
////// * Esse e um comentario de varias linhas
////// * 
////// */

//////// Mostro Texto na Tela
//////// Toda Instruçao termina com ;
//////Console.WriteLine("Ola Ryan");

//////// Guardar informaçoes
//////// 1. Variaveis (Caixinhas que guardam informaçao)

//////// TIPO NOME_DA_VARIAVEL = VALOR;
//////int idade = 25;
//////string nome = "Ryan";

//////// int - Integer (Numeros Inteiros)
//////// double/float - Numeros Quebrados
//////// string - Textos - ""

////////Constantes
////////E um valor que nao pode ser alterado
//////const double Pi = 3.14159;

//////Console.WriteLine(Pi);

//////var nomeR = "Ryan"; // o C# entende que e uma string.
//////var preco = 19.55; // o C# entende que e uma double.

//////char inicialDoNome = 'R';

//////Console.WriteLine("Digite o seu nome?");
//////string nomeUsuario = Console.ReadLine(); // Le o texto digitado

//////Console.WriteLine("Informe a sua idade?");
//////int idadeUsuario = int.Parse(Console.ReadLine());

//////Console.WriteLine("ola, " + nomeUsuario + " \nSua Idade e: " + idadeUsuario);


////////Interpolacao de Strings
//////Console.WriteLine($"ola, {nomeUsuario}! Voce tem {idadeUsuario} ");


//////Operacoes Aritmeticas

////int some = 10 + 5;
////int subtracao = 10 - 5;
//////int multiplicacao = 10 * 5;
////int divisao = 10 / 2;

//////resto da divisao -> Recebe o resto da divisao de 10 por 3.
////int modulo = 10 % 3;

////Console.WriteLine(some);
////Console.WriteLine(subtracao);
////Console.WriteLine(multiplicacao);
////Console.WriteLine(divisao);
////Console.WriteLine(modulo);

//// Lista 1 - Variáveis, Tipos e Leitura de Dados

//// Exercícios Fundamentais
//Console.WriteLine("-----------------------------------------\r\n    Exercícios Fundamentais\r\n-----------------------------------------");
////Exercícios 1 
//Console.WriteLine("Ola, Mundo");

////Exercícios 2 
//int numero = 10;
//Console.WriteLine(numero);

////Exercícios 3
//int a = 5;
//int b = 3;
//Console.WriteLine(a + b);

////Exercícios 4
//int num1 = 8;
//int num2 = 7;
//Console.WriteLine(num1 * num2);

//// Exercícios Intermediários
//Console.WriteLine("-----------------------------------------\r\n    Exercícios Intermediários\r\n-----------------------------------------");

//////Exercícios 1 
////string nome = "ana";
////Console.WriteLine("Ola, " + nome + (" Bem Vinda"));

//////Exercícios 2
////Console.WriteLine("Informe Um Numero? ");
////int valor = int.Parse(Console.ReadLine());
////Console.WriteLine(valor * 2);
////Console.WriteLine("Final Exercícios 2");

//////Exercícios 3

////Console.WriteLine("Me Informe um Numero: ");
////int Num1 = int.Parse(Console.ReadLine());

////Console.WriteLine("Me Informe um outro numero Numero: ");
////int Num2 = int.Parse(Console.ReadLine());

////Console.WriteLine("Me Informe um outro numero Numero: ");
////int Num3 = int.Parse(Console.ReadLine());

////Console.WriteLine("A Soma dos 3 numeros: " + (Num1 + Num2 + Num3)/3 );

//////Exercícios 4
////Console.WriteLine("Me Fale o seu Nome: ");
////string Nome = Console.ReadLine();

////Console.WriteLine("Me Fale a Sua Idade: ");
////int Idade = int.Parse(Console.ReadLine());

////Console.WriteLine("Me Fale a Sua Cidade: ");
////string Cidade = Console.ReadLine();

////Console.WriteLine($"Ola, {Nome}! a sua idade e: {Idade} Voce Mora em: {Cidade}");

//////Exercícios 5
////Console.WriteLine("Me da um Valor Do x: ");
////int x = int.Parse(Console.ReadLine());

////Console.WriteLine("Me da um Valor Do y: ");
////int y = int.Parse(Console.ReadLine());

////if (x < y)
////{
////    Console.WriteLine("Verdadeiro");
////}else{
////    Console.WriteLine("falso");
////}

//// Exercícios Avançados
//Console.WriteLine("-----------------------------------------\r\n    Exercícios Avançados\r\n-----------------------------------------");

//Console.WriteLine("-----------------------------------------\r\n    Exercícios Fundamentais\r\n-----------------------------------------");
////Exercícios 1

//Console.Write("Digite a sua Idade: ");
//int IdadeUsuario = int.Parse(Console.ReadLine());
//int Idades = 16;

//Console.WriteLine( IdadeUsuario >= Idades);
//// Essa parte do codigo esta Falando de a Idade do usuario e mais ou menor que variavel Idades que e 16 se for menor vai dar false e se for maior vai dar true

////Exercícios 2

//int Temperatura = 25;
//bool Resultado = Temperatura > 25 && Temperatura > 30;
//Console.WriteLine(Resultado);
///////////
//Console.WriteLine("Digite a temperatura da Sua Cidade: ");
//int Temperaturas = int.Parse(Console.ReadLine());
//bool Resultados = Temperatura > 25 && Temperatura > 30;
//Console.WriteLine(Resultados);

////Exercícios 3

//bool TemCartao = true;
//double Compra = 50.00;
//bool resultado = TemCartao || Compra > 100;
//Console.WriteLine(resultado);



// Lista 2 - Estruturas Condicionais

//Exercícios 1
//Console.WriteLine("Qual Ea Sua Idade: ");
//int idade = int.Parse(Console.ReadLine());
//if (idade >= 18)
//{
//    Console.WriteLine("Voce e maior de Idade");
//}
//else
//{
//    Console.WriteLine("Voce e menor de Idade");
//}

//Exercícios 2
//Console.WriteLine("Digite Um Numero: ");
//int Numero = int.Parse(Console.ReadLine());
//if( Numero >= 100)
//{
//    Console.WriteLine("O Seu Numero E positivo");
//}
//else if(Numero >= 100)
//{
//    Console.WriteLine("Seu Numero e Menor");
//}
//else
//{
//    Console.WriteLine("Seu Numero e Zero");
//}

////Exercícios 3
//Console.WriteLine("Digite Uma Nota Para Um Aluno \n ex: 7,10! ");
//double Nota = double.Parse(Console.ReadLine());
//if (Nota >= 7.0)
//{
//    Console.WriteLine("Voce Foi Aprovado");
//}
//else
//{
//    Console.WriteLine("Voce Foi Reprovado");
//}

//Console.WriteLine("-----------------------------------------\r\n    Exercícios Intermediários\r\n-----------------------------------------");

////Exercícios 1
//Console.WriteLine("Qual ea a Sua Idade: ");
//int Idade = int.Parse(Console.ReadLine());

//if(Idade <= 12)
//{
//    Console.WriteLine("Voce e Criança");
//}
//else if(Idade >= 13 && Idade <= 17)
//{
//    Console.WriteLine("Voce e Adolecente");
//}
//else
//{
//    Console.WriteLine("Voce e Adulto");
//}

////Exercícios 2
//bool tarefas = true;
//if(tarefas)
//{
//    Console.WriteLine("Sua Tarefas foi concluida!");
//}
//else
//{
//    Console.WriteLine("Sua Tarefas Nao foi pedent!");
//}

////Exercícios 3
//Console.WriteLine("Me da Uma Nota De 0 a 10: ");
//int nota  = int.Parse(Console.ReadLine());
//if (nota >= 10 && nota <= 1)
//{
//    Console.WriteLine("A Sua Nota Foi Valida");
//}
//else
//{
//    Console.WriteLine("A sua Nota Foi Invalida");
//}

////Exercícios 4
//Console.WriteLine("Qual eo seu Salario Mensal: ");
//double salarioMensal = double.Parse(Console.ReadLine());
//bool possuiRestricao = true;
//if (salarioMensal <= 2.000 && possuiRestricao)
//{
//    Console.WriteLine("Emprestimo Aprovado!");
//}
//else
//{
//    Console.WriteLine("Empréstimo negado");
//}

////Exercícios 5
//Console.WriteLine("Digite um Valor: ");
//double nota1 = double.Parse(Console.ReadLine());
//if(nota1 >= 7.0)
//{
//    Console.WriteLine("Aprovado!");
//}
//else if(nota1 >= 5.0 && nota1 <= 7.0)
//{
//    Console.WriteLine("Recuperaçao!");
//}
//else
//{
//    Console.WriteLine("Reprovado!");
//}


//Console.WriteLine("-----------------------------------------\r\n    Exercícios Avançados\r\n-----------------------------------------");

//////Exercícios 1
//Console.WriteLine("Digite Um Numero Para Adivinhar se e Par ou Impar: ");
//int numero = int.Parse(Console.ReadLine());
//string resultado = !(numero % 2 != 0) ? "Esse Numero e Par" : "Esse numero e Impar";
//Console.WriteLine(resultado);

//////Exercícios 2
//Console.WriteLine("Digite o valor da sua Compra: ");
//double valorCompra = double.Parse(Console.ReadLine());
//double resultadoCompra = valorCompra;
//if (valorCompra >= 200)
//{
//    resultadoCompra = valorCompra * 0.8;
//    Console.WriteLine("Compras acima de R$ 200,00 têm 20% de desconto.");
//}
//else if (valorCompra >= 100)
//{
//    resultadoCompra = valorCompra * 0.9;
//    Console.WriteLine("Compras entre R$ 100,00 (inclusive) e R$ 200,00 (exclusive) têm 10% de desconto.");
//}
//else
//{
//    Console.WriteLine("Compras abaixo de R$ 100,00 não têm desconto.");
//}
//Console.WriteLine(resultadoCompra);

////Operador Ternario (if/else)
//int idadeAluno = 34;
//string mensagem;

//if (idadeAluno > 18)
//{
//    mensagem = "maior de Idade";
//}
//else
//{
//    mensagem = "Menor de idade";
//}

//mensagem = (idadeAluno > 18) ? "Maior de Idade" : "Menor de idade";
//Console.WriteLine(mensagem);


//Estrutura Concionais (if/else)

//Estruturas de Repetiçao (repetem)

//while (enquanto)
// enquanto (condiçao for verdade) { faz algo}

//// Peço uma senha, enquanto a senha estiver errada, pergunto denovo
//Console.WriteLine("Digite a senha: ");
//string senha = Console.ReadLine();

////enquanto a senha e diferente de Ryan
//while (senha != "Ryan")
//{
//    Console.WriteLine("Senha Incorreta");
//    Console.WriteLine("Digite a senha: ");
//    senha = Console.ReadLine();

//}

// do/while

// for


// loops exercicios

using System.Runtime.Serialization;

Console.WriteLine("-----------------------------------------\r\n    Exercícios Fundamental\r\n-----------------------------------------");

////Exercícios 1
//int numero = 1;

//while(numero <= 10)
//{
//    Console.WriteLine(numero);
//    numero++;
//}

////Exercícios 2

//Console.WriteLine("Digite a senha: ");
//string senha = Console.ReadLine();
//while (senha != "123")
//{
//    Console.WriteLine("Senha Incorreta");
//    Console.WriteLine("Digite a senha: ");
//    senha = Console.ReadLine();

//}

////Exercícios 2
////Console.WriteLine("Executando o processo...");
////Console.WriteLine("Voce Deseja Execuktar de novo?");
////string letra;

////do
////{
////     letra = Console.ReadLine();
////    Console.WriteLine("Processo Encessaro!");

////} while (letra != "s" || letra != "S");

////Exercícios 3
//int numero1;
//int soma = 0;

//do
//{
//    Console.WriteLine("Digite um numero ou 0 para: ");
//    numero1 = int.Parse(Console.ReadLine());
//    soma += numero1;

//} while (numero1 != 0);
//Console.WriteLine(soma);

////Exercícios 4
//Console.WriteLine("Digite um numero vou te mostar a Tabuada Desse numero e: ");
//int numero3 = int.Parse(Console.ReadLine()); ;

//for (int i = 0; i <= 10; i ++)
//{
//    Console.WriteLine($"{numero3} X {i} = {numero3 * i}");
//}

////Exercícios 5
//Console.WriteLine("Digite um numero para somar ate 100: ");
//int numero4 = int.Parse(Console.ReadLine()); ;
//for (int i = 1; i < 100; i++)
//{
//    Console.WriteLine($"{numero4} + {i} = {numero4 + i}");
//}

Console.WriteLine("-----------------------------------------\r\n    Exercícios Intermediário\r\n-----------------------------------------");

//Exercícios 1
//Console.WriteLine("Digite a senha: ");
//string senha = Console.ReadLine();
//do
//{
//    Console.WriteLine("Senha Curta! \n deve ter no mínimo 8 caracteres.");
//    Console.WriteLine("Digite a senha: ");
//    senha = Console.ReadLine();
//    Console.WriteLine("cadastrada com sucesso!");
//} while (senha.Length != 8);

//Exercícios 2
//Console.WriteLine("Digite um numero inteiro: ");
//int n = int.Parse(Console.ReadLine());
//int soma = 1;
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine($"{n}! = {i} X {soma *= i}");
//}

////Exercícios 3
//int numeroUsuario = 0;
//int numeroSecreto = new Random().Next(1, 101);
//int tentativa = 0;
//while (numeroSecreto != numeroUsuario){
//    Console.WriteLine("Escolha Um Numero para adivinha 1 e 100: ");
//    numeroUsuario = int.Parse(Console.ReadLine());
//    tentativa++;
//    if (numeroUsuario >= numeroSecreto)
//    {
//        Console.WriteLine("O Numero da Sorte e Menor!");
//    }
//    else if (numeroUsuario <= numeroSecreto)
//    {
//        Console.WriteLine("O Numero da Sorte e maior");
//    }
//    else
//    {
//        Console.WriteLine($"Voce acertou o numero!");
//        Console.WriteLine($"Foram necessárias {tentativa} tentativas.");
//    }
//}

//Exercícios 4
int nu1 = 0;
int nu2 = 0;
int resultado;
int opçeo =  0 ;
do
{
    Console.WriteLine("opções 1 - Somar + \nopções 2 - Subtrair - \nopções 3 - Multiplicar * \nopções 4 - sair");
    Console.WriteLine("Escolha uma Operaçao!");

    opçeo = int.Parse(Console.ReadLine());

    switch (opçeo)
    {
        case 1:

            Console.WriteLine("Escolha um Numero: ");
            nu1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha outro Numero: ");
            nu2 = int.Parse(Console.ReadLine());

            resultado = (nu1 + nu2);
            Console.WriteLine($" o resultado e : {resultado}");
            
            break;
        case 2:

            Console.WriteLine("Escolha um Numero: ");
            nu1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha outro Numero: ");
            nu2 = int.Parse(Console.ReadLine());

            resultado = (nu1 - nu2);

            Console.WriteLine($" o resultado e : {resultado}");

            break;
        case 3:

            Console.WriteLine("Escolha um Numero: ");
            nu1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha outro Numero: ");
            nu2 = int.Parse(Console.ReadLine());

            resultado= (nu1 * nu2);
            Console.WriteLine($" o resultado e : {resultado}");

            break;
        case 4:

            Console.WriteLine("Processo Finalizado!");
            break;
    }
    
}while (opçeo != 4);