using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pembukaan : MonoBehaviour {

	  public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

      public void keluar()
      {
          Application.Quit();
      }
}

