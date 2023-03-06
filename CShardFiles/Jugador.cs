using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Jugador : CartaContainer
{
    public Carta[] cartasEnMano;
    public List<Carta> cartasEnMesa; //Por conveniencia cada jugador guarda también las cartas globales de la mesa

     public int Stock;

     public bool EstaRetirado;


    public Jugador(int dinero, Carta[] mano ,List<Carta> mesa)
    {
        this.cartasEnMesa = mesa;
        this.cartasEnMano = mano;
        this.Stock        = dinero;
        EstaRetirado = false;
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
        List<Carta> CartasTotal = cartasEnMesa;
        CartasTotal.Add(cartasEnMano[0]);
        CartasTotal.Add(cartasEnMano[1]);
        bool esEscalera = false;
        bool esPoker = false; int PokerSig =-1;
        bool esFull = false; int FullSig =-1; int Full2Sig =-1;
        bool esColor = false;
        bool esTrio = false; int Triosig = -1;
        bool es2Pareja = false; int par2sig1 =-1, par2sig2 =-1;
        bool es1Pareja = false; int parSig =-1;
       // Comprobar la escalera de color
            //Comprobar color
        if 
        (  CartasTotal.FindAll(x => x.getPalo() == Palo.C).Count > 4
        || CartasTotal.FindAll(x => x.getPalo() == Palo.P).Count > 4
        || CartasTotal.FindAll(x => x.getPalo() == Palo.T).Count > 4
        || CartasTotal.FindAll(x => x.getPalo() == Palo.D).Count > 4)
        {esColor = true;}

        List<int> valores = new List<int>();
        foreach (Carta c in CartasTotal)
        {
            valores.Add((int) c.getValor());
        }
        List<int> valoresSinRepetidos = valores.Distinct().ToList();
        valoresSinRepetidos.Sort();
         //Esto elimina las repeticiones por conveniencia
        //Comprueba otros tipos de manos, si no hay pokers ni fulls (que imposibilitan la escalera) entonces se comprueba
        
        
        
        //Comprobar si hay un poker
        for(int i = 1; i<=13;i++) {
        if (CartasTotal.FindAll(x => (int)(x.getValor()) == i).Count > 3)
        {esPoker = true; PokerSig = i;}
        }

        //Comprobar si hay un full
            //Comprobar si hay un trio
        for (int i=1; i<=13;i++)
        {
            if (CartasTotal.FindAll(x => (int)(x.getValor()) == i).Count > 2)
            {
                esTrio = true;
                Triosig = i;
            }
        }
            //Comprobar si además hay una pareja
        if (esTrio)
        {
            for (int i = 1; i<=13;i++)
            {
                if (i != Triosig && (CartasTotal.FindAll(x => (int)(x.getValor()) == i).Count > 1))
                {
                    esFull = true; FullSig = Triosig; Full2Sig = i;
                }
            }
        }
         //Comprobar dos parejas
            //Comprueba una
          for (int i=1; i<=13;i++)
        {
            if (CartasTotal.FindAll(x => (int)(x.getValor()) == i).Count > 1)
            {
                es1Pareja = true;
                parSig= i;
            }
        }
            //Comprobar si hay otra
        if (es1Pareja)
        {
            for (int i = 1; i<=13;i++)
            {
                if (i != parSig && (CartasTotal.FindAll(x => (int)(x.getValor()) == i).Count > 1))
                {
                    es2Pareja = true; par2sig1 = parSig; par2sig2 = i;
                }
            }
        }

        if (!esPoker && !esFull)
        {
            int coincidencias = 0;
            for (int i = 0; i < valoresSinRepetidos.Count - 1; i++)
            {   
                if (valoresSinRepetidos[i] == valoresSinRepetidos[i+1] - 1)
                {
                    coincidencias++;
                }
            }
            esEscalera = coincidencias >= 4;
        }

        return esEscalera && esColor? Mano.EscaleraColor
        :      esPoker? Mano.Poker
        :      esFull? Mano.Full
        :      esColor? Mano.Color
        :      esEscalera? Mano.Escalera
        :      esTrio? Mano.Trío
        :      es2Pareja? Mano.DoblePareja
        :      es1Pareja? Mano.Pareja
        :      Mano.CartaAlta;


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
