using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    void Awake()
    {
        instance = this;
    }
    public Text TimerText;
    private float StartTime;
    public Button pindah;
    bool klik = false;
    bool times = true;
    float t = 0;
    public int waktu;
    InventorySlot slot;
    Health health;
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        pindah.onClick.AddListener(Cliked);   
    }

    // Update is called once per frame
    void Update()
    {
       if(klik)
        {

            t += Time.deltaTime;
            string minutes = ((int)t / 60).ToString();
        string second = (t % 60).ToString("f1");

        TimerText.text = minutes + " : " + second;
            waktu = int.Parse(minutes);
            slot = InventorySlot.instance;
            health = Health.instance;
            score = Score.instance;
            if(slot.start == false || health.start == false || score.start == false)
            {
                klik = false;
            }
        }
        
    
    }
    void Cliked()
    {
        if(times == true)
        {
            StartTime = Time.time;
            times = false;
            klik = true;
        }
        
    }
}
