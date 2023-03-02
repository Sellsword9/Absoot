using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Este script debe poner el dinero del jugador en su stock y viceversa. También se encarga de las apuestas.
    public static int DineroJugador;


    public void Start() {
        DineroJugador = 1000;
    }
}
