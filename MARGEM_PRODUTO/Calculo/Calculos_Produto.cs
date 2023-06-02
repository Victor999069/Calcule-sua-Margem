using System;
using System.Collections.Generic;
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
        public double Frete_Compra { get; set; } //Valor de frete de compra
        public double Frete_Venda { get; set; } //Valor de frete de venda
        public double Custo_Aluguel { get; set; } //Custo pelo local de armazenagem dos produtos, pela loja ou por alguma hospedagem digital
        public double Investimento_Marketing { get; set; } //Valor investido em trafego de dados ou agencia de marketing
        public double Custo_Geral { get; set; } //Custo como embalagens, mão de obra contratada.
        public int Margem_Desejada { get; set; } //Informativo em percentual para calculo

        public double Calculo_Imposto() //Realiza o calculo do valor de imposto a pagar. O calculo considera o valor colocado pelo usuario.
        {
            double Preco_Imposto = Valor_Compra * Impostos / 100;
            Console.WriteLine("Preço do Imposto R$ " + Preco_Imposto);
            return Preco_Imposto;
        }

        public double Calculo_FreteCompra()
        {
            double Preco_Compra = Valor_Compra * Frete_Compra / 100;
            Console.WriteLine("Preço do Frete Envio R$ " + Preco_Compra);
            return Preco_Compra;
        }

        public void Calculo_Total()
        {
            double Valor_do_Imposto = Calculo_Imposto();
            double Valor_FreteCompra = Calculo_FreteCompra();
            double Valor_Total = Valor_do_Imposto + Valor_FreteCompra + Valor_Compra;
            Console.WriteLine("Valor Total R$ " + Valor_Total);
        }

        public void Retorno()
        {
           

            Console.WriteLine("Informe o valor de compra do item:");
            Valor_Compra = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual do imposto:");
            Impostos = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual médio do frete de compra:");
            Frete_Compra = double.Parse(Console.ReadLine());

            Calculo_Total();
        }

    }
}
