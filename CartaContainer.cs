using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CartaContainer 
{
    Mano mejorMano(); //Detecta la mejor mano del CartaContainer. Está preparado para usar el método CartaDefinir SOLO en caso de empate. 
    Carta CartaDefinir(); //Un método para casos de empate. Encargado de hacer que una escalera (2, 3, 4, 5, 6) pierda contra una escalera (8, 9, 10, J, K).
    int CartaMasAlta(); //Un método auxiliar pensado para facilitar casos de empate muy concretos, donde hayan manos de poco valor y se necesite acceder rapido a la carta más alta
}
