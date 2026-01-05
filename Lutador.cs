using System;

namespace RPGTurno;

class Lutador : Personagem
{
    public Lutador(string Nome)
        : base(Nome, Forca: 2, Agilidade: 3, Vida: 50, Defesa: 2)
    {}

    public override int Atacar()
    {
        int dano = base.Atacar();

        if (Critico())
        {
            Agilidade += 3;
            dano += 6;
            Console.WriteLine($"{Nome} fez um combo rápido!");
        }
        return dano;
    }
}
