using FlyWeight.Notas;
using System;
using System.Collections.Generic;

namespace FlyWeight
{
    public class Piano
    {

        public void Toca(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}