using System;

namespace RPGTurno
{
    class Personagem
    {
        public string Nome;
        public int Forca;
        public int Agilidade;
        public int Vida;
        public int Defesa;

        private Random rng = new Random();

        public Personagem(string Nome, int Forca, int Agilidade, int Vida, int Defesa)
        {
            this.Nome = Nome;
            this.Forca = Forca;
            this.Agilidade = Agilidade;
            this.Vida = Vida;
            this.Defesa = Defesa;
        }

        public virtual int Atacar()
        {
            int dano = rng.Next(1, (Forca + Agilidade) * 2);
            if (Critico())
            {
                dano *= 2;
            }
            return dano;
        }

        public virtual int Defender()
        {
            int absorcao = rng.Next(1, Defesa + Agilidade);

            if (Critico())
            {
                absorcao += 4;
            }
            return absorcao;
        }

        public bool Critico()
        {
            int chanceCritico = rng.Next(1, 5);

            if (chanceCritico == 4)
            {
                Console.WriteLine("Crítico!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
