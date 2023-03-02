using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbsootUnity : MonoBehaviour
{
    /*
    Clase pensada para comunicar Unity y las clases del juego. Realizará la mayoría de las acciones dentro del game envioroment de unity como tal.
    Cuando haya que revelar una carta, se llamará a un método de aquí. Cuando haya que regenerar las cartas, lo mismo. 
    Funciona como una unidad centralizada de comunicación entre el diagrama de clases y el GameEngine
    Sus métodos serán casi siempre void, están pensados para enviar una orden concreta a Unity 
    */
    
    public static GameObject TC1, TC2, TC3, TC4, TC5, OC1, OC2, E1C1, E1C2, E2C1, E2C2,E3C1, E3C2; //Los GameObjects de las cartas. T es prefijo de mesa, E de jugador, y O las tuyas propias
    

    
    public Sprite Reves;
    public Sprite AsPicas, DosPicas, TresPicas, CuatroPicas, CincoPicas, SeisPicas, SietePicas, OchoPicas, NuevePicas, DiezPicas, JotaPicas, ReinaPicas, ReyPicas;
    public Sprite AsTreboles, DosTreboles, TresTreboles, CuatroTreboles, CincoTreboles, SeisTreboles, SieteTreboles, OchoTreboles, NueveTreboles, DiezTreboles, JotaTreboles, ReinaTreboles, ReyTreboles;
    public Sprite AsCorazones, DosCorazones, TresCorazones, CuatroCorazones, CincoCorazones, SeisCorazones, SieteCorazones, OchoCorazones, NueveCorazones, DiezCorazones, JotaCorazones, ReinaCorazones, ReyCorazones;
    public Sprite AsDiamantes, DosDiamantes, TresDiamantes, CuatroDiamantes, CincoDiamantes, SeisDiamantes, SieteDiamantes, OchoDiamantes, NueveDiamantes, DiezDiamantes, JotaDiamantes, ReinaDiamantes, ReyDiamantes;

    //Los sprites se asignan a imágenes dentro del propio Unity

    private void Start() {
        TC1  = GameObject.Find("TC1");
        TC2  = GameObject.Find("TC2");
        TC3  = GameObject.Find("TC3");
        TC4  = GameObject.Find("TC4");
        TC5  = GameObject.Find("TC5");
        OC1  = GameObject.Find("OC1");
        OC2  = GameObject.Find("OC2");
        E1C1 = GameObject.Find("TC1");
        E1C2 = GameObject.Find("E1C2");
        E2C1 = GameObject.Find("E2C1");
        E2C2 = GameObject.Find("E2C2");
        E3C1 = GameObject.Find("E3C1");
        E3C2 = GameObject.Find("E3C2");
        
    }

    public static void ActualizarCarta(GameObject o, Carta c)
    {
        GameObject Scripter = GameObject.Find("Scripter");
       
            switch (c.getPalo())
            {
                case Palo.C : ActualizarCartaCorazones(o, (int)c.getValor(), Scripter); break;
                case Palo.D : ActualizarCartaDiamantes(o, (int)c.getValor(), Scripter); break;
                case Palo.P : ActualizarCartaPicas(o, (int)c.getValor(), Scripter); break;
                case Palo.T : ActualizarCartaTreboles(o, (int)c.getValor(), Scripter); break;
                default : throw new System.Exception("Error de actualización de cartas");
            }
    }

    private static void ActualizarCartaCorazones(GameObject o, int value, GameObject scripter)
    {
           AbsootUnity temp = scripter.GetComponent<AbsootUnity>();
        
        switch (value)
        {
            case 1: o.gameObject.GetComponent<Image>().sprite = temp.AsCorazones; break;
            case 2: o.gameObject.GetComponent<Image>().sprite = temp.DosCorazones; break;
            case 3: o.gameObject.GetComponent<Image>().sprite = temp.TresCorazones; break;
            case 4: o.gameObject.GetComponent<Image>().sprite = temp.CuatroCorazones; break;
            case 5: o.gameObject.GetComponent<Image>().sprite = temp.CincoCorazones; break;
            case 6: o.gameObject.GetComponent<Image>().sprite = temp.SeisCorazones; break;
            case 7: o.gameObject.GetComponent<Image>().sprite = temp.SieteCorazones; break;
            case 8: o.gameObject.GetComponent<Image>().sprite = temp.OchoCorazones; break;
            case 9: o.gameObject.GetComponent<Image>().sprite = temp.NueveCorazones; break;
            case 10: o.gameObject.GetComponent<Image>().sprite = temp.DiezCorazones; break;
            case 11: o.gameObject.GetComponent<Image>().sprite = temp.JotaCorazones; break;
            case 12: o.gameObject.GetComponent<Image>().sprite = temp.ReinaCorazones; break;
            case 13: o.gameObject.GetComponent<Image>().sprite = temp.ReyCorazones; break;
            default: o.gameObject.GetComponent<Image>().sprite = temp.Reves; break;
        }
    }

    private static void ActualizarCartaPicas(GameObject o, int value, GameObject scripter)
    {
       AbsootUnity temp = scripter.GetComponent<AbsootUnity>();
        
        switch (value)
        {
            case 1: o.gameObject.GetComponent<Image>().sprite = temp.AsPicas; break;
            case 2: o.gameObject.GetComponent<Image>().sprite = temp.DosPicas; break;
            case 3: o.gameObject.GetComponent<Image>().sprite = temp.TresPicas; break;
            case 4: o.gameObject.GetComponent<Image>().sprite = temp.CuatroPicas; break;
            case 5: o.gameObject.GetComponent<Image>().sprite = temp.CincoPicas; break;
            case 6: o.gameObject.GetComponent<Image>().sprite = temp.SeisPicas; break;
            case 7: o.gameObject.GetComponent<Image>().sprite = temp.SietePicas; break;
            case 8: o.gameObject.GetComponent<Image>().sprite = temp.OchoPicas; break;
            case 9: o.gameObject.GetComponent<Image>().sprite = temp.NuevePicas; break;
            case 10: o.gameObject.GetComponent<Image>().sprite = temp.DiezPicas; break;
            case 11: o.gameObject.GetComponent<Image>().sprite = temp.JotaPicas; break;
            case 12: o.gameObject.GetComponent<Image>().sprite = temp.ReinaPicas; break;
            case 13: o.gameObject.GetComponent<Image>().sprite = temp.ReyPicas; break;
            default: o.gameObject.GetComponent<Image>().sprite = temp.Reves; break;
        }
    }

    private static void ActualizarCartaDiamantes(GameObject o, int value, GameObject scripter)
    {
       AbsootUnity temp = scripter.GetComponent<AbsootUnity>();
        
        switch (value)
        {
            case 1: o.gameObject.GetComponent<Image>().sprite = temp.AsDiamantes; break;
            case 2: o.gameObject.GetComponent<Image>().sprite = temp.DosDiamantes; break;
            case 3: o.gameObject.GetComponent<Image>().sprite = temp.TresDiamantes; break;
            case 4: o.gameObject.GetComponent<Image>().sprite = temp.CuatroDiamantes; break;
            case 5: o.gameObject.GetComponent<Image>().sprite = temp.CincoDiamantes; break;
            case 6: o.gameObject.GetComponent<Image>().sprite = temp.SeisDiamantes; break;
            case 7: o.gameObject.GetComponent<Image>().sprite = temp.SieteDiamantes; break;
            case 8: o.gameObject.GetComponent<Image>().sprite = temp.OchoDiamantes; break;
            case 9: o.gameObject.GetComponent<Image>().sprite = temp.NueveDiamantes; break;
            case 10: o.gameObject.GetComponent<Image>().sprite = temp.DiezDiamantes; break;
            case 11: o.gameObject.GetComponent<Image>().sprite = temp.JotaDiamantes; break;
            case 12: o.gameObject.GetComponent<Image>().sprite = temp.ReinaDiamantes; break;
            case 13: o.gameObject.GetComponent<Image>().sprite = temp.ReyDiamantes; break;
            default: o.gameObject.GetComponent<Image>().sprite = temp.Reves; break;
        }
    }

    private static void ActualizarCartaTreboles(GameObject o, int value, GameObject scripter)
    {
         AbsootUnity temp = scripter.GetComponent<AbsootUnity>();
        
        switch (value)
        {
            case 1: o.gameObject.GetComponent<Image>().sprite = temp.AsTreboles; break;
            case 2: o.gameObject.GetComponent<Image>().sprite = temp.DosTreboles; break;
            case 3: o.gameObject.GetComponent<Image>().sprite = temp.TresTreboles; break;
            case 4: o.gameObject.GetComponent<Image>().sprite = temp.CuatroTreboles; break;
            case 5: o.gameObject.GetComponent<Image>().sprite = temp.CincoTreboles; break;
            case 6: o.gameObject.GetComponent<Image>().sprite = temp.SeisTreboles; break;
            case 7: o.gameObject.GetComponent<Image>().sprite = temp.SieteTreboles; break;
            case 8: o.gameObject.GetComponent<Image>().sprite = temp.OchoTreboles; break;
            case 9: o.gameObject.GetComponent<Image>().sprite = temp.NueveTreboles; break;
            case 10: o.gameObject.GetComponent<Image>().sprite = temp.DiezTreboles; break;
            case 11: o.gameObject.GetComponent<Image>().sprite = temp.JotaTreboles; break;
            case 12: o.gameObject.GetComponent<Image>().sprite = temp.ReinaTreboles; break;
            case 13: o.gameObject.GetComponent<Image>().sprite = temp.ReyTreboles; break;
            default: o.gameObject.GetComponent<Image>().sprite = temp.Reves; break;
        }
    }

    public static void ResetCarta(GameObject o)
    {
        o.gameObject.GetComponent<Image>().sprite = GameObject.Find("Scripter").GetComponent<AbsootUnity>().Reves;
    }
    
    
    
}
