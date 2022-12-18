using Formula;
CAlC c = new CAlC();
bool menu = true;
while (menu)
{

    Console.WriteLine("Inicio ");
    Console.WriteLine("Digite o primeiro valor para iniciar a calculadora ");
    
     try
    {
        c.p1 = double.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
        
        throw new ArgumentException("Digite o primeiro valor para iniciar a calculadora ");
    }
    Console.WriteLine("Tudo bem ");
    Console.Clear();
    Console.WriteLine("segundo o  valor agora");
    try
    {
            c.p2 = Convert.ToDouble(Console.ReadLine());
    }
    catch (System.Exception)
    {
        
        throw new ArgumentException(" Digite o segundo valor para iniciar a calculadora ");
    }






    Console.Clear();
    Console.WriteLine("Você deseja Adição + ");
    Console.WriteLine("Você deseja Subtrair - ");
    Console.WriteLine("Você deseja Dividir / ");
    Console.WriteLine("Você deseja Multiplicar * ");
    Console.WriteLine("Você deseja Saber a porcentagem % ");
    Console.WriteLine("Você deseja Saber a raiz  quadrada 0 ");
    Console.WriteLine("Sair aperte s");

    switch (Console.ReadLine())
    {
        case "+":
            c.Somar();
            break;
        case "-":
            c.Subtrair();
            break;
        case "/":
            c.Dividir();
            break;
        case "*":
            c.Multiplicar();
            break;
        case "%":
            c.Porcentagem();
            break;
        case "0":
            c.Raiz_Quadrada();
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;

        case "s":
            menu = false;
            break;

    }
    Console.WriteLine("Aperte enter para prosseguir");

}
Console.WriteLine("O programa finalizou ");
Console.ReadKey();
