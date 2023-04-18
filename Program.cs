Console.Clear();
here:
// Funcao para a senha.
static bool VerificarSenha()
{
    Console.Write("Digite a senha: ");
    string senha = Console.ReadLine();
    return senha == "007";
}
// Verificacao da senha
if (!VerificarSenha())
{
    Console.WriteLine("Senha incorreta!");
    goto here;
}
else
{
    Console.WriteLine($"Usuario logado");
    Thread.Sleep(2000);
    Console.Clear();
}
// Um Array com uma class passagem
Passagem[] passagens = new Passagem[5];
int quantidadePassagens = 0;
int opcao = -2;

// loop de repticao setado para ficar sempre dentro do menu
while (opcao != 0)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1- Cadastrar passagem");
    Console.WriteLine("2- Listar passagens");
    Console.WriteLine("0- Sair");
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

// switch para realiozar bloco de codigos para cada caso que o usuario digitar 
    switch (opcao)
    {
        case 1:
        // loop de repeticao para salvar cada coisa digitada dentro do array e dentro das variaveis salvas dentro 
        // da classe
        
            for (int i = 0; i < 5; i++)
            {
                // usado o null para ver se esta vazio o array se for diferende ele executa a acao 
                if (passagens[i] == null)
                {
                    passagens[i] = new Passagem();

                    Console.Write("Digite o nome do passageiro: ");
                    passagens[i].nome = Console.ReadLine().ToLower().Trim(' ');

                    Console.Write("Digite a origem do voo: ");
                    passagens[i].origem = Console.ReadLine().ToLower().Trim(' ');

                    Console.Write("Digite o destino do voo: ");
                    passagens[i].destino = Console.ReadLine().ToLower().Trim(' ');

                    Console.Write("Digite a data do voo (dd/mm/aaaa): ");
                    passagens[i].dataVoo = Console.ReadLine().ToLower().Trim(' ');

                    Console.Write("Passagem cadastrada com sucesso!");

                    Console.Write("\nDeseja cadastrar outra passagem? (S/N): ");
                    string opcaoCadastro = Console.ReadLine().ToUpper().Trim(' ');

                    if (opcaoCadastro == "N")
                    {
                        Console.Clear();
                        break;

                    }
                    else
                    {
                        Console.Clear();
                    }
                    // usando o readkey para aguardar usuario e retorna-lo para o menu 
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
            break;



        case 2:
        // usando o for para ele percorre todo o passagens 
            Console.WriteLine($"Listagem de Passagens\n");

            bool passagensCadastradas = false;

            for (int i = 0; i < passagens.Length; i++)
            {
                // se estiver diferente de vazio ele exibir da classe dentro do array
                if (passagens[i] != null)
                {
                    Console.WriteLine($"Passageiro:{passagens[i].nome}");
                    Console.WriteLine($"Origem:{passagens[i].origem}");
                    Console.WriteLine($"Destino:{passagens[i].destino} ");
                    Console.WriteLine($"Data do Voo:{passagens[i].dataVoo} ");
                    Console.WriteLine();
                    passagensCadastradas = true;
                }
              

                if (!passagensCadastradas)
                {
                    Console.WriteLine("Não há passagens cadastradas.\n");
                    break;
                }
            }
            break;
            
        case 0:
            Console.WriteLine("Saindo do sistema...\n");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.\n");
            break;
    }
}



// Classes com variaveis usadas dentro do for 

class Passagem
{
    public string nome;
    public string origem;
    public string destino;
    public string dataVoo;
}