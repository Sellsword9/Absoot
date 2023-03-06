using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CartaContainer 
{
    public abstract Mano mejorMano(); //Detecta la mejor mano del CartaContainer. Está preparado para usar el método CartaDefinir SOLO en caso de empate. 
    public abstract Carta CartaDefinir(); //Un método para casos de empate. Encargado de hacer que una escalera (2, 3, 4, 5, 6) pierda contra una escalera (8, 9, 10, J, K).
    public abstract int CartaMasAlta(); //Método autodescriptivo. Util para casos muy variopintos de empates o faroles que salgan mal.

    public abstract List<Carta> totalCartas();
    //Este método, en la mesa, devuelve todas las cartas, en los jugadores, devuelve primero las cinco de la mesa, y luego las dos del jugador
}
