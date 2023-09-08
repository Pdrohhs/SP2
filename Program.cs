using System;
using System.Globalization;

namespace AtividadeSP2
{
    class Program{
        static void Main(string[] args){
        Pessoa_Fisica pessoaf = new Pessoa_Fisica();
        Pessoa_Juridica pessoaj = new Pessoa_Juridica();

        Console.WriteLine("Informe o seu nome:");
        string nomepessoa = Console.ReadLine();
        Console.WriteLine("Informe seu endereço:");
        string enderecopessoa = Console.ReadLine();
        Console.WriteLine("Pessoa Física ou Jurídica? (Responda com f ou j)");
        string tipo = Console.ReadLine();


        if(tipo == "f")
        {
            pessoaf.nome = nomepessoa;
            pessoaf.endereco = enderecopessoa;

            Console.WriteLine("Digite seu CPF: (Modelo: '000.000.000-00')");
            pessoaf.cpf = Console.ReadLine();
            Console.WriteLine("Digite seu RG: (Modelo: '00.000.000')");
            pessoaf.rg = Console.ReadLine();
            Console.WriteLine("Digite o valor da compra para calcular o imposto: ");
            float valorpf = float.Parse(Console.ReadLine());
            pessoaf.Pagar_Imposto(valorpf);

            Console.Write("---------- Pessoa Física ---------- \n");
            Console.Write("Nome: " + pessoaf.nome);
            Console.Write("\nEndereço: " + pessoaf.endereco);
            Console.Write("\nCPF: " + pessoaf.cpf);
            Console.Write("\nRG: " + pessoaf.rg);
            Console.Write("\nImposto a pagar: " + pessoaf.valor_imposto.ToString("C"));
            Console.Write("\nTotal a pagar: " + pessoaf.total.ToString("C"));

        }
        if(tipo == "j")
        {
            pessoaj.nome = nomepessoa;
            pessoaj.endereco = enderecopessoa;

            Console.WriteLine("Digite seu CNPJ: (Modelo: '000.000.000-00')");
            pessoaj.cnpj = Console.ReadLine();
            Console.WriteLine("Digite seu IE: (Modelo: '00.000.000')");
            pessoaj.ie = Console.ReadLine();
            Console.WriteLine("Digite o valor da compra para calcular o imposto: ");
            float valorpj = float.Parse(Console.ReadLine());
            pessoaj.Pagar_Imposto(valorpj);

            Console.Write("---------- Pessoa Jurídica ---------- \n");
            Console.Write("Nome: " + pessoaj.nome);
            Console.Write("\nEndereço: " + pessoaj.endereco);
            Console.Write("\nCPF: " + pessoaj.cnpj);
            Console.Write("\nRG: " + pessoaj.ie);
            Console.Write("\nImposto a pagar: " + pessoaj.valor_imposto.ToString("C"));
            Console.Write("\nTotal a pagar: " + pessoaj.total.ToString("C"));
        }

        }
    }

}