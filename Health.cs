using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health instance;
    void Awake()
    {
        instance = this;
    }
    Score score = Score.instance;

    public Text ScoreText;
    public int health;
    public int numHeart;
    public bool start = true;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Button reset;
    public GameObject UI;
    public void Update()
    {
        for (int i=0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < numHeart)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

        }    
    }
    public void GameOver()
    {
        if(health == 0)
        {
            start = false;
            ScoreText.text = " Anda Kalah Harap Coba Lagi " ;
            ScoreText.color = Color.red;
            reset.gameObject.SetActive(true);
            UI.gameObject.SetActive(false);
        }
    }
    public void MinusNyawa()    
    {
        //Debug.Log("Nyawa = "+ health.ToString());
        //score.HitungScore(health.ToString()); 
        health--;
        /*if (health != 0)
        {
            ScoreText.text = "Nyawa anda tinggal " + health.ToString();
        }*/
        if(health == 0)
        {
            ScoreText.text = "Nyawa Habis";
        }
        else if(health > 0)
        {
            ScoreText.color = Color.red;
            ScoreText.text = " anda salah meletakkan hewan " +
                "Nyawa anda tinggal " + health.ToString();
        }
       
    }

}
