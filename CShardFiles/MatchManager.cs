using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchManager : MonoBehaviour
{
    public int Bote;
    public static int CiegaG;
    public static int CiegaP;

    public static Baraja barajaEnJuego;

    public static List<Carta> TreceCartas; // Guarda las trece primeras cartas: Las primeras 5 van a mesa, las siguientes seis se dan a los rivales y las últimas dos para ti

    public static List<Carta> Mesa; //Las cinco carta de la mesa. Hecha por eficiencia y legibilidad. 
    void Start()
    {
        barajaEnJuego = new Baraja().mezclar();
        TreceCartas = barajaEnJuego.getPrimerasCartas(13);
        for (int i=0; i<5;i++)
        {
            Mesa.Add(TreceCartas[i]);
        }
        CiegaG = 40;
        CiegaP = 20;

    }

    public static void testVerCartas()
    {
        foreach (Carta c in TreceCartas)
        {
            UnityEngine.Debug.Log("Carta: " + (int)c.getValor() + " del palo " + (int)c.getPalo());
        }
    }

     public static void testCuentaCartas()
    {
        
            UnityEngine.Debug.Log("Cartas en juego: " + TreceCartas.Count);
            UnityEngine.Debug.Log("Cartas en  "       + TreceCartas.Count);
    }

    void MainInit(int dInicial)
    {
        CartaContainer mesa = new MesaType(MatchManager.Mesa); //Poliformismo innecesario por ahora, pero podría ser conveniente
        Jugador e1     =  new Jugador(dInicial, new Carta[]{TreceCartas[5],  TreceCartas[6]}, Mesa );
        Jugador e2     =  new Jugador(dInicial, new Carta[]{TreceCartas[7],  TreceCartas[8]}, Mesa);
        Jugador e3     =  new Jugador(dInicial, new Carta[]{TreceCartas[9],  TreceCartas[10]}, Mesa);
        Jugador player =  new you    (          new Carta[]{TreceCartas[11], TreceCartas[12]}, Mesa);
        
    }

    void Pasar(Jugador j)
    {

    }

    void Apostar(Jugador j, int d)
    {

    }
}
