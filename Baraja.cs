using System;
using System.Collections.Generic;
public class Baraja
{
    List<Carta> orden;
    public Baraja() //Crea una baraja ordenada 
    {
        for (int a = 1; a<52; a++)
        {
            orden.Add(new Carta(a));
        }
    }

    public void mezclar()
    {
        int a;
        int b;
        Random r = new Random();
        for (int i = 0; i < 10000; i++)
            {
            do //Solo para asegurarse
            {
            a = r.Next(0, 53);
            } while (a > 52 || a < 1);

            do //Solo para asegurarse
            {
            b = r.Next(0, 53);
            } while (b > 52 || b < 1);
            
            Carta temp = this.orden[a];
            this.orden[a] = this.orden[b];
            this.orden[b] = temp;
            }

        
    }
}
