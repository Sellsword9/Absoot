using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchManager : MonoBehaviour
{
    
    public static int Bote;
    public static int CiegaG;
    public static int CiegaP;

    public static int MinActual;

    public static GameObject txtStock;

    public static GameObject txtBote;

    public static GameObject txtApuestaE1, txtApuestaE2, txtApuestaE3;

    public static bool HaJugado, esperando;

    public static int partidas;


    public static int TipoJugada;

    public static Baraja barajaEnJuego;

    public static Jugador J1, J2, J3; 
    public static you p;

    public static List<Carta> TreceCartas; // Guarda las trece primeras cartas: Las primeras 5 van a mesa, las siguientes seis se dan a los rivales y las últimas dos para ti

    public static List<Carta> Mesa; //Las cinco carta de la mesa. Hecha por eficiencia y legibilidad. 
    public void Start()
    {
        txtStock = GameObject.Find("txtDinero");
        txtApuestaE1 = GameObject.Find("txtApuesta1");
        txtApuestaE2 = GameObject.Find("txtApuesta2");
        txtApuestaE3 = GameObject.Find("txtApuesta3");
        txtBote = GameObject.Find("txtBote");
        Bote = 0;
        CiegaG = 40;
        CiegaP = 20;
        esperando = false;
        MainInit(1); //TODO

    }

    static void MainInit(int dInicial)
    {
        if (PlayerManager.DineroJugador <= 0)
        {
            partidas++;
            PlayerManager.DineroJugador = 1000;
        }
        barajaEnJuego = new Baraja().mezclar();
        TreceCartas = barajaEnJuego.getPrimerasCartas(13);
        Mesa = new List<Carta>();
        for (int i=0; i<5;i++)
        {
            Mesa.Add(TreceCartas[i]);
        }
        CartaContainer mesa = new MesaType(MatchManager.Mesa); //Poliformismo innecesario por ahora, pero podría ser conveniente
        J3     =  new Jugador(dInicial, new Carta[]{TreceCartas[5],  TreceCartas[6]}, Mesa );
        J2     =  new Jugador(dInicial, new Carta[]{TreceCartas[7],  TreceCartas[8]}, Mesa);
        J1     =  new Jugador(dInicial, new Carta[]{TreceCartas[9],  TreceCartas[10]}, Mesa);
        p      =  new you    (          new Carta[]{TreceCartas[11], TreceCartas[12]}, Mesa);
    }

     void Update()
    {
        txtStock.GetComponent<Text>().text = "Stock: " + p.Stock;
        txtBote.gameObject.GetComponent<Text>().text = Bote + "";
    }


    // A partir de aquí el código se encarga de gestionar las partidas. 

   
}
