using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApuestaManager : MonoBehaviour
{
    public GameObject btnNext;
    public GameObject btnSub, btnVer, bntFold;

    public MatchManager matchManager;

    public int maxApuesta;

    public bool posiblenext;
    
    public void Start() {
      posiblenext = true;
    }
    public void Update()
    {
        if (posiblenext)
        {
            btnNext.gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 1);
        }
    }
    
    public void SiguienteRonda()
    {
        if (posiblenext)
        {
        posiblenext = false;
        matchManager.Start();
        btnNext.gameObject.GetComponent<Image>().color = new Color(255, 255, 255, 0.1f);
        MatchManager.HaJugado = false;
        AbsootUnity.ActualizarCarta(GameObject.Find("OC1"), MatchManager.p.cartasEnMano[0]);
        AbsootUnity.ActualizarCarta(GameObject.Find("OC2"), MatchManager.p.cartasEnMano[1]);
        AbsootUnity.ResetCarta(GameObject.Find("E1C1"));
        AbsootUnity.ResetCarta(GameObject.Find("E1C2"));
        AbsootUnity.ResetCarta(GameObject.Find("E2C1"));
        AbsootUnity.ResetCarta(GameObject.Find("E2C2"));
        AbsootUnity.ResetCarta(GameObject.Find("E3C1"));
        AbsootUnity.ResetCarta(GameObject.Find("E3C2"));
        
        int i = 0;
        foreach (Carta c in MatchManager.Mesa)
        {
            AbsootUnity.ActualizarCarta(GameObject.Find("TC" + (i+1)), c);
            i++;
        }
        IAE1();
        }
    }

    private void IAE1()
    {
        int apuesta = 0;
        if (((int) MatchManager.J1.cartasEnMano[0].getValor()) == 1 || ((int) MatchManager.J1.cartasEnMano[1].getValor()) == 1 || ((int)MatchManager.J1.cartasEnMano[0].getValor()) > 10 || ((int) MatchManager.J1.cartasEnMano[1].getValor()) > 10 )
        {           
            apuesta = 100 +  new System.Random().Next(-25, 35);
            MatchManager.txtApuestaE1.gameObject.GetComponent<Text>().text = apuesta + "";
            MatchManager.Bote += apuesta;
            MatchManager.MinActual=apuesta;
            InfoManager.Info("R1 parecía decidido esta ronda. En total ha apostado " + apuesta);
        }
        else
        {
            InfoManager.Info("R1 se retiró pronto esta ronda");
            MatchManager.txtApuestaE1.gameObject.GetComponent<Text>().text = "--";
            MatchManager.J1.EstaRetirado = true;
        }
        IAE2(apuesta);
    }
    private void IAE2(int min)
    {
        int apuesta = 0;
        Carta[] c = MatchManager.J2.cartasEnMano;
        if (c[0].GetType() == c[1].GetType())
        {
            apuesta = min +  new System.Random().Next(0, 80);
            InfoManager.Info("R2 aparenta estar de farol y va con " + apuesta);
            MatchManager.txtApuestaE2.gameObject.GetComponent<Text>().text = apuesta + "";
            min = apuesta;
        }
        else if(c[0].getValor() == c[1].getValor())
        {
            apuesta = min +  new System.Random().Next(0, 80);
            InfoManager.Info("R2 aparenta estar de farol y va con " + apuesta);
            MatchManager.txtApuestaE2.gameObject.GetComponent<Text>().text = apuesta + "";
            min = apuesta;
        }
        else
        {
            apuesta = 40 + new System.Random().Next(0, 10);
            InfoManager.Info("R2 se retiró, pero apostó " + apuesta + " antes de retirarse");
            MatchManager.txtApuestaE2.gameObject.GetComponent<Text>().text = "--";
            MatchManager.J2.EstaRetirado = true;
        }
        MatchManager.Bote += apuesta;
        bool YouEsDealer = (new System.Random().Next(0, 8) > 4);
        IAE3(min, YouEsDealer);
    }
    private void IAE3(int min, bool YouEsDealer)
    {
        if (YouEsDealer && MatchManager.J2.EstaRetirado && MatchManager.J1.EstaRetirado)
        {
            MatchManager.Bote += (int) (MatchManager.CiegaG + (min / 1.2f));
            InfoManager.Info("R3 ha pasado este último turno.");
            MatchManager.txtApuestaE3.gameObject.GetComponent<Text>().text = "-";
        }
        else
        {
            MatchManager.Bote += min;
            InfoManager.Info("R3 ve.");
            MatchManager.txtApuestaE3.gameObject.GetComponent<Text>().text = min +"";
        }
        InfoManager.Info("¿Subes a " + (2 * min) + "?¿Ves los " + min + "?¿O te retiras y pierdes " + (int) ((min/1.5f) + MatchManager.CiegaP) + "?");
        maxApuesta = min;
    }

    
    public void Subir()
    {
        InfoManager.Info("Vas con " + 2 *maxApuesta);
        if (new System.Random().Next(0, 104) > 60)
        {
            InfoManager.Info("Tus rivales se retiran. Te llevas el bote");
            ganar();

        }
        else
        {
            InfoManager.Info("Mejor que no estés de farol");
            if (CheckGanador())
             {
               ganar();
               InfoManager.Info("Bonita mano. Tú ganas");
             }
             else
             {
                perder2();
             }
        }
    }
    public void Ver()
    {
        InfoManager.Info("Ves los " + maxApuesta);
        
        if (CheckGanador())
        {
            ganar();
            InfoManager.Info("Has ganado, bien hecho");
        }
        else
        {
            perder();
        }
    }

    private void ganar()
    {
        PlayerManager.DineroJugador += MatchManager.Bote;
        this.Start();
    }

    private void perder2()
    {
        PlayerManager.DineroJugador -= 2 * maxApuesta;
        InfoManager.Info("Has acabado perdiendo.");
        this.Start();
    }
    private void perder()
    {
        PlayerManager.DineroJugador -= maxApuesta;
        InfoManager.Info("Has perdido");
        this.Start();
    }

    public void foldear()
    {
        PlayerManager.DineroJugador -= (int) ((maxApuesta/1.5f) + MatchManager.CiegaP);
        InfoManager.Info("Bueno, una retirada a tiempo es media victoria...");
        this.Start();
    }
    
    
    private bool CheckGanador()
    {
        Debug.Log(MatchManager.p.mejorMano());

        bool HasGanado = false;
        List<Jugador> rivales = new List<Jugador>();
        if (!MatchManager.J1.EstaRetirado)
        {
            rivales.Add(MatchManager.J1);
            AbsootUnity.ActualizarCarta(GameObject.Find("E1C1"), MatchManager.J1.cartasEnMano[0]);
            AbsootUnity.ActualizarCarta(GameObject.Find("E1C2"), MatchManager.J1.cartasEnMano[1]);
        }
        if (!MatchManager.J2.EstaRetirado)
        {
            rivales.Add(MatchManager.J2);
            AbsootUnity.ActualizarCarta(GameObject.Find("E2C1"), MatchManager.J2.cartasEnMano[0]);
            AbsootUnity.ActualizarCarta(GameObject.Find("E2C2"), MatchManager.J2.cartasEnMano[1]);
        }
        if (!MatchManager.J3.EstaRetirado)
        {
            AbsootUnity.ActualizarCarta(GameObject.Find("E3C1"), MatchManager.J3.cartasEnMano[0]);
            AbsootUnity.ActualizarCarta(GameObject.Find("E3C2"), MatchManager.J3.cartasEnMano[1]);
            rivales.Add(MatchManager.J3);
        }
        foreach (Jugador r in rivales)
        {
             
            HasGanado = ( (int) (MatchManager.p.mejorMano())) >= ( (int) (r.mejorMano())); 
            if (!HasGanado)
            {
                break;
            }
        }
        return HasGanado;
    }
}


