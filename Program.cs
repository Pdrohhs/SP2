using System;

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
            Console.WriteLine("Digite seu CPF: (Modelo: '000.000.000-00')");
            pessoaf.cpf = Console.ReadLine();
            Console.WriteLine("Digite seu RG: (Modelo: '00.000.000')");
            pessoaf.rg = Console.ReadLine();
            Console.WriteLine("Digite o valor da compra para calcular o imposto: ");
            float valorpf = float.Parse(Console.ReadLine());
            pessoaf.Pagar_Imposto(valorpf);
            Console.WriteLine("O valor total a pagar é.....: " + pessoaf.total.ToString("C"));

        }
        if(tipo == "j")
        {
            Console.WriteLine("Digite seu CNPJ: (Modelo: '000.000.000-00')");
            pessoaj.cnpj = Console.ReadLine();
            Console.WriteLine("Digite seu IE: (Modelo: '00.000.000')");
            pessoaj.ie = Console.ReadLine();
            Console.WriteLine("Digite o valor da compra para calcular o imposto: ");
            float valorpj = float.Parse(Console.ReadLine());
            pessoaj.Pagar_Imposto(valorpj);
            Console.WriteLine("O valor total a pagar é.....: " + pessoaj.total.ToString("C"));
        }

        }
    }

}