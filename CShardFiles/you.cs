using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class you : Jugador
{

    /* El constructor incializa una instancia de la clase you, que está relacionada con el jugador como tal. 
      Su función es almacenar los datos de las cartas, pero no apostar ni nada de eso. De eso se encargara la clase PlayerManager
      Al llamar al super (base) llama al constructor de Jugador y le pasa PlayerManager.DineroJugador
    */
   
   
    public you(Carta[] mano, List<Carta> mesa) : base (PlayerManager.DineroJugador, mano, mesa)
    {
      //Si se necesitan protecciones irán aquí
    }


}
