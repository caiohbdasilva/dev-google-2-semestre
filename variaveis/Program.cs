// Variáveis
    // Tipos Primitivos
        // Tipos Inteiros
            byte idadeMinima = 10; //0 até 255
            short teste = 50; // -32768 até 32767
            int teste2 = 100; // -2bi até 2bi
            long teste3 = 1000; // >2bi
            // Console.WriteLine(idadeMinima);

        // Tipos Reais
            float notaMedia = 7.5f;
            double temperatura = 22.37;
            decimal preco = 18.99m;
            // Console.WriteLine($"Nota Média: {notaMedia}");
            // Console.WriteLine($"Temperatura: {temperatura} °C");
            // Console.WriteLine($"Valor: {preco} R$");

        // Tipos Booleano
            bool maiorIdade = true; // Verdadeiro
            bool menorIdade = false; // Falso

        // Tipos Carateres (Tipos para texto)
            char letra = 'a'; // Somente um único caractere; apenas aspas simples (')
            string mensagem = "Olá, mundo!"; // Mais de um caractere;
            // System.Console.WriteLine(mensagem);

// ============================================================================================

// Declaração e Atribuição
int ano; // Declaração
ano = 2026;// Atribuição

var cidade = "Recife";
var media = 8.2;

// ============================================================================================

// Constantes
const double pi = 3.14159; //Não mudam de valor, idependente da situação

// ============================================================================================

// Parse
string entrada = "25";
int idade = int.Parse(entrada); // Conversão de string para int

double a = 9.7;
int b = (int)a; //Conversõ de double para int

// ============================================================================================

// Entrada e Saída de dados
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine(nome);

// ============================================================================================
// Operadores Aritiméticos

int c = 5, d = 2;
int soma = c+d;
int menos = c-d;
int divisao = c/d;
double divisaoInteira = (double)c / d;
int resto = c%d;
int multiplicacao = c*d;
// ============================================================================================

// Operadores Comparativos

int x = 5;
int y = 2;

bool igual = (x == y);
bool diferente = (x != y);
bool maior = (x>y);
bool menor = (x<y);
bool maiorOuIgual = (x>=y);
bool menorOuIgual = (x<=y);

// ============================================================================================

// Operadores Lógicos
    // && (E)
    bool condicao1 = true;
    bool condicao2 = false;

    bool resultado = condicao1 && condicao2;

    // || (ou)




