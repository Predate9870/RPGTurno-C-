using System;

namespace RPGTurno
{
class Jogo
{
    static void Main(string[] args)
    {
        Mago player = new Mago("Raiden");
        Guerreiro inimigo = new Guerreiro("Ares");
        Random rng = new Random();
        int PlayerDefesa = player.Defender();

        while (player.Vida > 0 && inimigo.Vida > 0)
        {
            Console.WriteLine("Escolha sua ação: ");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Defender");

            string escolha = Console.ReadLine();
            int decisãoI = rng.Next(1, 3);

            int ataqueP = 0;
            int defesaP = 0;
            int ataqueI = 0;
            int defesaI = 0;

            if (escolha == "1")
            {
                ataqueP = player.Atacar();
            } else
            {
                defesaP = player.Defender();
                Console.WriteLine("Você se preparou para defender...");
            }

            if (decisãoI == 1)
            {
                ataqueI = inimigo.Atacar();
                Console.WriteLine("O inimigo ataca!");
            } else
            {
                defesaI = inimigo.Defender();
                Console.WriteLine("O inimigo se preparou para defender...");
            }


            if (inimigo.Vida <= 0)
            {
                inimigo.Vida = 0;
                Console.WriteLine("Você venceu o inimigo!");
                break;
            }
            else if (player.Vida <= 0)
            {
                Console.WriteLine("Você foi derrotado pelo inimigo!");
                break;
            }

            int danoP = ataqueP - defesaI;
            if (danoP < 0) danoP = 0;
            inimigo.Vida -= danoP;

            int danoI = ataqueI - defesaP;
            if (danoI < 0) danoI = 0;
            player.Vida -= danoI;

            if (ataqueP > 0)
            {
                Console.WriteLine($"Você causou {danoP} de dano ao inimigo.");
            }
            if (ataqueI > 0)
            {
                Console.WriteLine($"O inimigo causou {danoI} de dano a você.");
            }
            Console.WriteLine($"Sua vida: {player.Vida} | Vida do inimigo: {inimigo.Vida}");

            Console.WriteLine(player.Vida > 0 && inimigo.Vida > 0 ? "Próximo turno" : $"Você venceu {inimigo.Nome}!");
        }
    }
}
}
