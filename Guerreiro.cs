using System;

namespace RPGTurno;

class Guerreiro : Personagem
{
    public Guerreiro(string Nome)
        : base(Nome, Forca: 3, Agilidade: 2, Vida: 55, Defesa: 3)
    {}

    public override int Defender()
    {
        int bloqueio = base.Defender();

        if (Critico())
        {
            bloqueio += 6;
            Console.WriteLine($"{Nome} realizou um bloqueio perfeito!");
        }
        return bloqueio;
    }
}