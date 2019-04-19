using System;

namespace HouseSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cozinha
            Cozinha cozinha = new Cozinha();
            cozinha.largura = 3;
            cozinha.comprimento = 4;
            cozinha.temGeladeira = true;

            //Sala
            Sala sala = new Sala();
            sala.largura = 5;
            sala.comprimento = 3;
            sala.temPainel = false;

            //Banheiro
            Banheiro banheiro1 = new Banheiro();
            banheiro1.largura = 2;
            banheiro1.comprimento = 1;
            banheiro1.temChuveiro = true;
            banheiro1.temEspelho = false;
            banheiro1.temEspelho = true;

            Banheiro banheiro2 = new Banheiro();
            banheiro2.largura = 2;
            banheiro2.comprimento = 1;
            banheiro2.temChuveiro = false;
            banheiro2.temEspelho = false;
            banheiro2.temEspelho = false;

            //Quarto
            Quarto quarto1 = new Quarto();
            quarto1.largura = 2;
            quarto1.comprimento = 2;
            quarto1.temArmarioEmbutido = false;
            quarto1.temSuite = false;

            Quarto quarto2 = new Quarto();
            quarto2.largura = 2;
            quarto2.comprimento = 2;
            quarto2.temArmarioEmbutido = true;
            quarto2.temSuite = true;


            //Casa
            Casa casa = new Casa();
            casa.endereco = "Itajubá";
            casa.proprietario = "Luiza";
            casa.valor = 60000;
            casa.cozinha = cozinha;
            casa.sala = sala;
            casa.addBanheiro(banheiro1);
            casa.addBanheiro(banheiro2);
            casa.addQuarto(quarto1);
            casa.addQuarto(quarto2);

            float calculaIPTU = casa.calculaIPTU();
            Console.WriteLine("O IPTU é: R$ " + calculaIPTU);
            casa.mostrainfos();


        }
    }
}
