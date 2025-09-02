using FilaCircular;


string opcao = ""; // variável que irá pegar a opção que o usuário desejar 
string valor; // valor que o usuário irá inserir na fila circular
Fila fila = new Fila(5); // definindo o tamanho da fila em cinco

Console.WriteLine("Sistema em C# para testar a execução de uma fila circular\n");

do
{
    try
    {
        Console.Write("\nDigite: \n\n   1-> Enfileirar \n\n   2-> Desenfileirar " +
        "\n\n   3-> Imprimir \n\n   9-> Sair \n\n   Sua opção --> ");
        opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.Write("Digite um valor para enfileirar: ");
                valor = Console.ReadLine();
                fila.Enfileirar(valor);
                break;
            case "2":
                Console.WriteLine("Desenfileirado: {0}");
                fila.Desenfileirar();
                break;
            case "3":
                Console.WriteLine("Impressão da fila");
                fila.Imprimir();
                Console.ReadKey();
                break;
            case "9":
                Console.WriteLine("Saindo do sistema...");
                break;
            default:
                Console.WriteLine("Opção inválida!!!");
                break;
        }
    }
    catch (Exception erro)
    {
        Console.WriteLine(erro.Message);
    }
    Console.Clear();
} while (opcao != "9");


// VERSÃO USANDO O COMANDO SE
//string opcao = ""; // variável que irá pegar a opção que o usuário desejar 
//string valor; // valor que o usuário irá inserir na fila circular
//Fila fila = new Fila(5); // definindo o tamanho da fila em cinco

//Console.WriteLine("Sistema em C# para testar a execução de uma fila circular.\n");


//while (opcao != "9")
//{
//    Console.Write("\nDigite: \n\n   1-> Enfileirar \n\n   2-> Desenfileirar " +
//    "\n\n   3-> Imprimir \n\n   9-> Sair \n\n   Sua opção --> ");
//    opcao = Console.ReadLine();

//    if (opcao == "1")
//    {
//        Console.Write("Digite um valor para enfileirar: ");
//        valor = Console.ReadLine();
//        fila.Enfileirar(valor);
//    }

//    if (opcao == "2")
//    {
//        Console.WriteLine("Desenfileirado:");
//        fila.Desenfileirar();
//    }

//    if (opcao == "3")
//    {
//        Console.WriteLine("Impressão da fila");
//        fila.Imprimir();
//        Console.WriteLine("Pressione uma tecla...");
//        Console.ReadKey();
//    }

//    if (opcao == "9")
//    {
//        Console.WriteLine("Saindo do sistema...");
//    }

//    Console.Clear();
//};