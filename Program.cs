using System;
using DesafioPOO.Models;

Nokia nokiaMobile = new Nokia(numero: "+1 555 310-4567", modelo: "Mobira Cityman 1320", imei: "0x2A8FBC734D9E01F", memoria: 32);
Iphone iphoneMobile = new Iphone(numero: "+44 20 7123-4567", modelo: "Original 2G", imei: "0x2A8FBC734D9E01F", memoria: 32);

Smartphone currentPhone = null;

Console.WriteLine("Bem-vindo ao simulador de smartphones!");

while (true)
{
    Console.WriteLine("\nOpções:");
    Console.WriteLine("1. Usar o Nokia");
    Console.WriteLine("2. Usar o iPhone");
    Console.WriteLine("3. Sair");

    Console.Write("Escolha uma opção: ");
    string escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            currentPhone = nokiaMobile;
            Console.WriteLine("Agora você está usando o Nokia.");
            break;

        case "2":
            currentPhone = iphoneMobile;
            Console.WriteLine("Agora você está usando o iPhone.");
            break;

        case "3":
            Console.WriteLine("Programa encerrado");
            return;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    if (currentPhone != null)
    {
        while (true)
        {
            Console.WriteLine("\nOpções para o smartphone selecionado:");
            Console.WriteLine("1. Ligar");
            Console.WriteLine("2. Receber ligação");
            Console.WriteLine("3. Instalar aplicativo");
            Console.WriteLine("4. Trocar de smartphone");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    currentPhone.Ligar();
                    break;

                case "2":
                    currentPhone.ReceberLigacao();
                    break;

                case "3":
                    currentPhone.InstalarAplicativo("");
                    break;

                case "4":
                    currentPhone = null;
                    Console.WriteLine("Você voltou para o menu de seleção de smartphone.");
                    break;

                case "5":
                    Console.WriteLine("Saindo do programa. Adeus!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
