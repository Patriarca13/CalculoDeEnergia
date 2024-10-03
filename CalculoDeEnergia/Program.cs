using CalculoDeEnergia;
using System;
using System.Globalization;

Calculos calculo = new Calculos();

    string opcao;
    bool exibirMenu = true;
    

    while(exibirMenu)
    {
        //Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Realizar Calculo de Kw: ");
        Console.WriteLine("2 - Realizar Calculo de energia:");
        Console.WriteLine("3 - Encerrar");
        opcao = Console.ReadLine();
       
        switch (opcao)
        {
            case "1":
                Console.WriteLine("Realizar calculo de kw ");
            Console.WriteLine("Digite o valor do talão de energia e o consumo: ");
            calculo.Consumo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            calculo.Talao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("O valor do kw foi de:" + calculo.Ckw().ToString("F2"));
            break;
            case "2":
                Console.WriteLine("Realizar calculo de energia");
            Console.Write("Digite o valor do kw e as leituras:");
            calculo.Kw = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            calculo.UltimaLeituraEnergia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            calculo.LeituraAtualEnergia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Voce deseja calcular a água tambem? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Quais as ultimas leituras: ");
                calculo.UltimaleituraAgua = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                calculo.LeituraAtualAgua = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("O valor total foi de:" + calculo.ValorTotal().ToString("F2"));
            }
            else if (resp == 'n' || resp == 'N')
            {
                Console.WriteLine("O valor da energia foi de: "+ calculo.ValorTotal().ToString("F2"));
            }



            break;
            case "3":
                Console.WriteLine("Encerrando...");
                exibirMenu = false;
            break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
