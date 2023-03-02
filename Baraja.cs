using System.Diagnostics;
using System;
using System.Collections.Generic;
using UnityEngine;
public class Baraja
{
    List<Carta> Cartas;
    public Baraja() //Crea una baraja ordenada 
    {
        Cartas = new List<Carta>();
        for (int a = 1; a<53; a++)
        {
            Cartas.Add(new Carta(a));
          //  UnityEngine.Debug.Log(a);
          // UnityEngine.Debug.Log(Cartas.Count); //test purposes
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
        System.Random r = new System.Random();
        for (int i = 0; i < 52; i++)
            {
            a = r.Next(0, 52);
           // UnityEngine.Debug.Log(a);
            b = r.Next(0, 52);
           // UnityEngine.Debug.Log(b);
            
            Carta temp = this.Cartas[a];
            this.Cartas[a] = this.Cartas[b];
            this.Cartas[b] = temp;
            }

        return this;

        
    }

    public List<Carta> getPrimerasCartas(int num)
    {
        List<Carta> cartasReturn = new List<Carta>();
        for (int i = 0; i<=num; i++)
        {
            cartasReturn.Add(Cartas[i]);
        }
        return cartasReturn;
    }
}
