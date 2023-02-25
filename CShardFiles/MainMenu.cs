<<<<<<< HEAD
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
=======
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
>>>>>>> 33ddc09d9a08aac7057d812d02672065407ffde0
