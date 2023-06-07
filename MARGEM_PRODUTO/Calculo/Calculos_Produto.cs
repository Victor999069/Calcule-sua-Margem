using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARGEM_PRODUTO.Calculo
{
    public class Calculos_Produto
    {
        static void Main(string[] args)
        {
            Calculos_Produto APP = new Calculos_Produto();
            APP.Retorno();
        }
        public double Valor_Compra { get; set; } //Custo pela aquisição do produto |
        public double Impostos { get; set; } //Imposto cobrado na compra do produto |
        public double Frete_Compra { get; set; } //Valor de frete de compra |
        public double Frete_Venda { get; set; } //Valor de frete de venda |
        public double Custo_Aluguel { get; set; } //Custo pelo local de armazenagem dos produtos, pela loja ou por alguma hospedagem digital |
        public double Investimento_Marketing { get; set; } //Valor investido em trafego de dados ou agencia de marketing |
        public double Custo_Geral { get; set; } //Custo como embalagens, mão de obra contratada. |
        public double Margem_Desejada { get; set; } //Informativo em percentual para calculo

        public double Calculo_Imposto() //Realiza o calculo do valor de imposto a pagar. O calculo considera o valor colocado pelo usuario.
        {
            double Preco_Imposto = Valor_Compra * Impostos / 100;
            Console.WriteLine("Preço do Imposto R$ " + Preco_Imposto);
            return Preco_Imposto;
        }
        Console.WriteLine();

        public double Calculo_FreteCompra()
        {
            double FT_Compra = Valor_Compra * Frete_Compra / 100;
            Console.WriteLine("Preço do Frete Compra R$ " + FT_Compra);
            return FT_Compra;
        }
        Console.WriteLine();

        public double Calculo_FreteVenda()
        {
            double FT_Venda = Valor_Compra * Frete_Venda / 100;
            Console.WriteLine("Preço do Frete Venda R$ " + FT_Venda);
            return FT_Venda;
        }
        Console.WriteLine();
        public double Calculo_Aluguel()
        {
            double Cus_Aluguel = Valor_Compra * Custo_Aluguel / 100;
            Console.WriteLine("O valor do aluguel sobre a compra é R$ " + Cus_Aluguel);
            return Cus_Aluguel;
        }
        Console.WriteLine();

        public double Calculo_Marketing()
        {
            double In_Markerting = Valor_Compra * Investimento_Marketing / 100;
            Console.WriteLine("O investimento de marketing no produto é R$ " + In_Markerting);
            return In_Markerting;
        }
        Console.WriteLine();
        public double Calculo_CustoGeral() 
        { 
            double Cus_Geral = Valor_Compra * Custo_Geral / 100;
            Console.WriteLine("O seu custo geral é de R$ " + Cus_Geral);
            return Cus_Geral;
        }
        Console.WriteLine();
        public void Calculo_Total()
        {
            double Valor_do_Imposto = Calculo_Imposto();
            double Valor_FreteCompra = Calculo_FreteCompra();
            double Valor_FreteVenda = Calculo_FreteVenda();
            double Valor_Aluguel = Calculo_Aluguel();
            double Valor_Marketing = Calculo_Marketing();
            double Valor_CustoGeral = Calculo_CustoGeral();
            double Valor_Custo_Total = Valor_do_Imposto + Valor_FreteCompra + Valor_FreteVenda + Valor_Aluguel + Valor_Marketing + Valor_CustoGeral + Valor_Compra;
            Console.WriteLine("Valor do produto + o custo é R$ " + Valor_Custo_Total);
            Console.WriteLine();
            double Valor_Produto_Mais_Margem = (Valor_Custo_Total * Margem_Desejada) / 100 + Valor_Custo_Total;
            Console.WriteLine("Valor com margem é R$ " + Valor_Produto_Mais_Margem);
        }

        public void Retorno()
        {
           

            Console.WriteLine("Informe o valor de compra do item:");
            Valor_Compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual do imposto:");
            Impostos = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual médio do frete de compra:");
            Frete_Compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual médio do frete de venda:");
            Frete_Venda = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual médio do custo de aluguel:");
            Custo_Aluguel = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual médio do investimento de marketing:");
            Investimento_Marketing = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual médio do custo geral:");
            Custo_Geral = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a margem que deseja:");
            Margem_Desejada = double.Parse(Console.ReadLine());

            Calculo_Total();
        }

    }
}
