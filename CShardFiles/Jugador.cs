using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : CartaContainer
{
    public Carta[] cartasEnMano;
    public List<Carta> cartasEnMesa; //Por conveniencia cada jugador guarda también las cartas globales de la mesa

     public int Stock;


    public Jugador(int dinero, Carta[] mano ,List<Carta> mesa)
    {
        this.cartasEnMesa = mesa;
        this.cartasEnMano = mano;
        this.Stock        = dinero;
    }

    public override Carta CartaDefinir()
    {
        throw new System.NotImplementedException();
    }

    public override int CartaMasAlta()
    {
        throw new System.NotImplementedException();
    }

    public override Mano mejorMano()
    {
        throw new System.NotImplementedException();
    }

    public override List<Carta> totalCartas()
    {
        List<Carta> totalCartas = new List<Carta>();
        foreach (Carta c in cartasEnMesa)
        {
            totalCartas.Add(c);
        }
        foreach (Carta c in cartasEnMano)
        {
            totalCartas.Add(c);
        }
        return totalCartas;
    }
}
