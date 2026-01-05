using System;

namespace RPGTurno;

class Barbaro : Personagem
{
    public Barbaro(string Nome)
        : base(Nome, Forca: 4, Agilidade: 1, Vida: 50, Defesa: 2)
    {}

    public override int Atacar()
    {
        int dano = base.Atacar();

        if (Critico())
        {
            dano *= 2;
            Console.WriteLine($"{Nome} fez um golpe devastador!");
        }
        return dano;
    }
}