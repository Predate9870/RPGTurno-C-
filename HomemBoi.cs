using System;

namespace RPGTurno;

class HomemBoi : Personagem
{
    public HomemBoi(string Nome)
        : base(Nome, Forca: 3, Agilidade: 2, Vida: 55, Defesa: 5)
    {}

    public override int Defender()
    {
        int bloqueio = base.Defender();

        if (Critico())
        {
            bloqueio *= 2;
            Console.WriteLine($"{Nome} virou uma muralha impenetrável!");
        }
        return bloqueio;
    }
}