using System.Globalization;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileManager : MonoBehaviour
{
    public static int GamesCount;
    public static StreamWriter writer;
    
    public static void CreateNewGameFile()
    {
        writer = File.CreateText("./Assets/GameData/Save " + GamesCount + ".txt");
        writer.WriteLineAsync(GamesCount +"");
        writer.WriteLineAsync("Money");
        writer.WriteLineAsync(1000 + "");
        FileManager.GameCountUp();
        writer.Close();
    }
    
    
    private static void GameCountUp()
    {
        if (GamesCount <= 0)
        {
            GamesCount = 0;
        }
        GamesCount++;
    }
}