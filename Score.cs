using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public Text ScoreText;
    int waktu;
    public GameObject[] Hewan;
    public GameObject[] Nyawa;
    int a = 3;
    public bool start = true;
    public Button reset;
    public GameObject UI;
    Timer time;
    Health health;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        if(Nyawa.Length == 2)
        {
            //HitungScore();
        }
    }

    void Update()
    {
        //ScoreText.text = Timer.text.ToString();    
    }
    public void HitungScore()
    {
        time = Timer.instance;
        waktu = time.waktu;
       if(waktu >= 2)
        {
            ScoreText.text = "Selemat Anda Mendapat Nilai " +
                "C";
            
            start = false;
        }else if(waktu >= 1)
        {
            ScoreText.text = "Selemat Anda Mendapat Nilai " +
                "B";
            start = false;
        }
        else if (waktu >= 0)
        {
            ScoreText.text = "Selemat Anda Mendapat Nilai " +
                "A";
            start = false;
        }
        else if (waktu > 3)
        {
            health = Health.instance;
            health.GameOver();
            start = false;
        }
        Debug.Log(" waktu " + waktu);
        ScoreText.color = Color.green;
        ScoreText.fontSize = 60;
        reset.gameObject.SetActive(true);
        UI.gameObject.SetActive(false);
    }

}
