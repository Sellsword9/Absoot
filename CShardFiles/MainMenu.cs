using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public static void NewGame()
  {
    FileManager.CreateNewGameFile();
    SceneManager.LoadScene(1);
  }

}
