using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class perhitunganlevel2 : MonoBehaviour {
    // Use this for initialization
    Text resultText;
    // Text resultUlang;
    double result = 0.0;
    double tempSave;
    string operation;
    double multiplier = 1;
    double memory;

    public GameObject restartText;
    public GameObject resultUlang;
    public GameObject ilangpapan;
    public GameObject munculpapan;
  //  public GameObject pasangmuncul;

    // selesai
    public GameObject ladangjadi;
    public GameObject ladangjadi2;
    public GameObject ladanglama;
    public GameObject ladanglama2;
    public GameObject soal;
    public GameObject soal2;
    public GameObject berhasil;

    //lives
    public bool isDead;
    public int lives;
    public bool isImmune;
    public float immuneCounter;
    public float immuneTime;

    public bool outsideForce;





    int resultNumber;
    void Start()
    {
        resultText = GameObject.Find("Result").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isImmune)
        {
            immuneCounter -= Time.deltaTime;

        }
        if (immuneCounter <= 0)
        {
            isImmune = false;
            immuneCounter = immuneTime;
        }
    }

    public void WriteToTextField()
    {
        resultText.text = "" + result;
    }

    public void ClearResult()
    {
        result = 0.0;
        WriteToTextField();
        multiplier = 1;
        restartText.SetActive(false);

    }

    public void saveOperation(string o) // untuk +-*/
    {
        multiplier = 1;
        operation = o;
        tempSave = result;
        result = 0.0;

        resultText.text = operation;
    }

    public void AddDigit(int d) // letakkan di angka
    {
        if (multiplier == 1)
        {
            result *= 10;
            result += d;
            WriteToTextField();
        }
        else
        {
            result += d * multiplier;
            multiplier /= 10;

        }
    }

    public void setMultiplier()
    {
        multiplier = 0.1;

    }

    public void saveMemory()
    {
        memory = result;
        multiplier = 1;

    }

    public void readMemory()
    {
        result = memory;
        WriteToTextField();
        multiplier = 1;

    }

    public void AddDigitPI()
    {
        double d = System.Math.PI;
        if (multiplier == 1)
        {
            result *= 10;
            result += d;
        }
        else
        {
            result += d * multiplier;
            multiplier /= 10;
        }
        WriteToTextField();
    }

    public void calcResult() // letakkan di cek
    {
        switch (operation)
        {
            case "+":
                result = tempSave + result;

                if (result != 125 && lives > 1 && !isImmune)
                {
                    restartText.SetActive(true);

                    resultUlang.SetActive(true);
                    lives--;
                    isImmune = true;

                }
                if (lives < 1)
                {
                    SceneManager.LoadScene("misigagal");
                }
                if (result == 125)
                {
                    ilangpapan.SetActive(false);
                    munculpapan.SetActive(true);
                  //  pasangmuncul.SetActive(true);
                   

                }
                //else
                //{

                //    Debug.Log("salah");
                //}
                break;

            case "-":
                result = tempSave - result;
                break;

            case "/":
                result = tempSave / result;
                break;

            case "*":
                result = tempSave * result;
                break;

        }

        operation = "";
        multiplier = 1;
        WriteToTextField();


    }

    public void selesai()
    {
        ladangjadi.SetActive(true);
        ladangjadi2.SetActive(true);
        ladanglama.SetActive(false);
        ladanglama2.SetActive(false);
        soal.SetActive(false);
        soal2.SetActive(false);
        berhasil.SetActive(true);

    }

    void OnGUI()
    {
        GUI.contentColor = Color.yellow;
        GUILayout.Label("\n           X " + lives);


    }
}
