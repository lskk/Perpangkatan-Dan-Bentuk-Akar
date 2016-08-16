using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class mati : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "klc")
        {
            Debug.Log("Dead");
            SceneManager.LoadScene("misigagal");
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "klc")
        {
            Debug.Log("Dead");
            SceneManager.LoadScene("misigagal");
        }
    }

    //void OnCollisionEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "kcl")
    //    {
    //        Debug.Log("Dead");
    //        SceneManager.LoadScene("misigagal");
    //    }
    //}


           
}
