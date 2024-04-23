using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Qual a marca do seu smartphone?");
Console.WriteLine("1 - Nokia");
Console.WriteLine("2 - Iphone");    
string marca = Console.ReadLine();


Console.Clear();
Console.WriteLine("Qual o número do seu smartphone?");
string numero = Console.ReadLine();

Console.Clear();
Console.WriteLine("Qual o modelo do seu smartphone?");
string modelo = Console.ReadLine();

Console.Clear();
Console.WriteLine("Qual o IMEI do seu smartphone?");
string imei = Console.ReadLine();

Console.Clear();
Console.WriteLine("Qual o tamanho da memoria  do seu smartphone?");
int memoria = int.Parse(Console.ReadLine());

Smartphone smartphone = marca == "1" ? new Nokia(numero, modelo, imei, memoria) : new Iphone(numero, modelo, imei, memoria);



while(true){
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Ligar");
    Console.WriteLine("2 - Receber ligação");
    Console.WriteLine("3 - Listar aplicativos");
    Console.WriteLine("4 - Instalar aplicativo");
    Console.WriteLine("5 - Exibir especificações");
    Console.WriteLine("6 - Sair");
    string opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            smartphone.Ligar();
            break;
        case "2":
            smartphone.ReceberLigacao();
            break;
        case "3":
            smartphone.ListarAplicativos();
            break;
        case "4":
            Console.WriteLine("Qual aplicativo deseja instalar?");
            string app = Console.ReadLine();
            smartphone.InstalarAplicativo(app);
            break;
        case "5":
            smartphone.ExibirSpecs();
            break;    
        case "6":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}


