using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class misigagal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnGUI() {
        GUI.contentColor = Color.red;
        if (GUI.Button(new Rect(Screen.width/2-50,Screen.height/2+150,100,40), "Ulangi"))
        {
          //  Application.LoadLevel(0);
            SceneManager.LoadScene(0);
        }
        if (GUI.Button(new Rect(Screen.width/2-50,Screen.height/2+200,100,40), "Keluar"))
        {
            Application.Quit();
        }

    }
}
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using System.Collections;

//namespace SceneTute {
//    public class Game : MonoBehaviour
//    {
//        public LoadSceneMode loadMode = LoadSceneMode.Single;
//        public void LoadScene(string sceneName)
//        {
//            SceneManager.LoadScene(sceneName,loadMode);
//        }
//        public void LoadScene(int sceneIndex)
//        {
//            SceneManager.LoadScene(sceneIndex, loadMode);
//        }
//    }

//}

