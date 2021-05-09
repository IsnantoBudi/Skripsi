using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Stop : MonoBehaviour
{
    public Text TimerText;
    private float StartTime;
    public Button pindah;
    bool klik;
    float t = 0;
  

    // Start is called before the first frame update
    void Start()
    {
        klik = false;
        //pindah.onClick.AddListener(Cliked);
    }

    // Update is called once per frame
    void Update()
    {

        mulai();

        

    }
    void mulai()
    {
        if (klik) {
            Debug.Log("true");
         t += Time.deltaTime ;

        string minutes = ((int)t / 60).ToString();
        string second = (t % 60).ToString("f1");

        TimerText.text = minutes + " : " + second;
        }
        else
        {
            //Debug.Log("false");
        }
    }

    void Cliked()
    {
        Debug.Log("klik");
        klik = !klik;
    }

}
