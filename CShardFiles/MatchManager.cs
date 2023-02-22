using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{
    public int Bote;
    public static int CiegaG;
    public static int CiegaP;
    void Start()
    {
        
    }

    void MainInit(int dInicial)
    {
        Jugador e1 = new Jugador(dInicial, null ); //TODO
        Jugador e2 = new Jugador(dInicial, null);
        Jugador e3 = new Jugador(dInicial, null);
        
    }

    void Pasar(Jugador j)
    {

    }

    void Apostar(Jugador j, int d)
    {

    }
}
