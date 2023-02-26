using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Test()
    {
        GameObject o = GameObject.Find("OC1");
        AbsootUnity.ActualizarCarta(o, new Carta(Valor.A, Palo.P));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
