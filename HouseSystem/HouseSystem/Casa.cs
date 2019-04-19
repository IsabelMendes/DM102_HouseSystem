using System;
using System.Collections.Generic;
using System.Text;

namespace HouseSystem
{
    class Casa : IDivulga, IContabil
    {
        public String endereco;
        public String proprietario;
        public float valor;
        public Sala sala;
        public Cozinha cozinha;
        public ICollection<Quarto> quartos = new HashSet<Quarto>();
        public ICollection<Banheiro> banheiros = new HashSet<Banheiro>();



        public float calculaIPTU()
        {
            return valor*0.01f+300;
        }

        public void mostrainfos()
        {
            Console.WriteLine("A casa possui uma cozinha com " +cozinha.largura+ " metros de largura e " +cozinha.comprimento+ " metros de comprimento");
            Console.WriteLine("A casa possui uma sala com " +sala.largura+" metros de largura e "+sala.comprimento+" metros de comprimento");

            foreach (Banheiro banheiro in banheiros)
            {
                Console.WriteLine("A casa possui um banheiro com " + banheiro.largura + " metros de largura e " + banheiro.comprimento + " metros de comprimento. E " + (banheiro.temChuveiro ? "possui chuveiro" : "não possui chuveiro")
                    + (banheiro.temEspelho ? ", possui espelho" : ", não possui espelho") + (banheiro.temVasoSanitario ? " e possui vaso sanitário." : " e não possui vaso sanitário."));

            }
            foreach (Quarto quarto in quartos) { 
            
                Console.WriteLine("A casa possui um quarto com " + quarto.largura + " metros de largura e " + quarto.comprimento + " metros de comprimento. E " + (quarto.temArmarioEmbutido ? "possui armário embutido" : "não possui armário embutido")
                    + (quarto.temSuite? " e possui suíte." : " e não possui suíte."));

            }

        }
        public void addBanheiro (Banheiro banheiro)
        {
            banheiros.Add(banheiro);
        }
        public void addQuarto (Quarto quarto)
        {
            quartos.Add(quarto);
        }
    }
}
