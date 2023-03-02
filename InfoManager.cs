using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    //Encargada de actualizar la información In-Game
    public static GameObject info, info2, info3, info4, info5;

    private void Start() {
        info = GameObject.Find("txtInfo");
        info2 = GameObject.Find("txtInfo2");
        info3 = GameObject.Find("txtInfo3");
        info4 = GameObject.Find("txtInfo4");
        info5 = GameObject.Find("txtInfo5");
    }

    public static void Info(string s)
    {
        info5.gameObject.GetComponent<Text>().text = info4.gameObject.GetComponent<Text>().text;
        info4.gameObject.GetComponent<Text>().text = info3.gameObject.GetComponent<Text>().text;
        info3.gameObject.GetComponent<Text>().text = info2.gameObject.GetComponent<Text>().text;
        info2.gameObject.GetComponent<Text>().text = info.gameObject.GetComponent<Text>().text;
        info.gameObject.GetComponent<Text>().text = "> " + s;
    }
    
}
