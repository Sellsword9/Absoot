using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : CartaContainer
{
    public Carta[] cartasEnMano;
    public Carta[] cartasEnMesa;

     public int Stock;


    public Jugador(int dinero, Carta[] mesa)
    {
        this.Stock = dinero;
        this.cartasEnMesa = mesa;
    }

    public Carta CartaDefinir()
    {
        throw new System.NotImplementedException();
    }

    public int CartaMasAlta()
    {
        throw new System.NotImplementedException();
    }

    public Mano mejorMano()
    {
        throw new System.NotImplementedException();
    }
}
