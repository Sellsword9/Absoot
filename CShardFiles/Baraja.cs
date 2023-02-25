<<<<<<< HEAD
using System;
using System.Collections.Generic;
public class Baraja
{
    List<Carta> Cartas;
    public Baraja() //Crea una baraja ordenada 
    {
        for (int a = 1; a<52; a++)
        {
            Cartas.Add(new Carta(a));
        }
    }

    public static Baraja getRandom() //Crea y devuelve una baraja randomizada
    {
        return new Baraja().mezclar();
    }

    public Baraja mezclar()
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
            
            Carta temp = this.Cartas[a];
            this.Cartas[a] = this.Cartas[b];
            this.Cartas[b] = temp;
            }

        return this;

        
    }

    public List<Carta> getPrimerasCartas(int num)
    {
        List<Carta> cartasReturn = new List<Carta>();
        for (int i = 0; i<num; i++)
        {
            cartasReturn.Add(Cartas[i]);
        }
        return cartasReturn;
    }
}
=======
using System;
using System.Collections.Generic;
public class Baraja
{
    List<Carta> Cartas;
    public Baraja() //Crea una baraja ordenada 
    {
        for (int a = 1; a<52; a++)
        {
            Cartas.Add(new Carta(a));
        }
    }

    public static Baraja getRandom() //Crea y devuelve una baraja randomizada
    {
        return new Baraja().mezclar();
    }

    public Baraja mezclar()
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
            
            Carta temp = this.Cartas[a];
            this.Cartas[a] = this.Cartas[b];
            this.Cartas[b] = temp;
            }

        return this;

        
    }

    public List<Carta> getPrimerasCartas(int num)
    {
        List<Carta> cartasReturn = new List<Carta>();
        for (int i = 0; i<num; i++)
        {
            cartasReturn.Add(Cartas[i]);
        }
        return cartasReturn;
    }
}
>>>>>>> 33ddc09d9a08aac7057d812d02672065407ffde0
