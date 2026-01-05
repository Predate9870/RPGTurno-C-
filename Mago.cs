using System;

namespace RPGTurno;
class Mago : Personagem
{
    public int Mana;
    Random rng = new Random();

    public Mago(string Nome)
        : base(Nome, Forca: 1, Agilidade: 2, Vida: 40, Defesa: 1)
    { }

    public override int Atacar()
    {
        Mana = rng.Next(1, 3);
        
        if (Mana == 1)
        {
            int dano = base.Atacar();
            Console.Write($"{Nome} usou a magia de fogo!");
            dano += 10;
            return dano;
        }
        else
        {
            int defesa = base.Defender();
            Console.WriteLine($"{Nome} levantou uma parede de pedra!");
            defesa += 10;
            return defesa;
        }
    }
}
