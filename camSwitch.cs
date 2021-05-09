using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camSwitch : MonoBehaviour
{
    public static camSwitch instance;
    public GameObject camKandang;
    public Text namaBioma;
    public Text scoretext;


    public GameObject[] Biomas;
    int counter = 8;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        suffleBioma(Biomas);

    }


    public void suffleBioma(GameObject[] bioma)
    {
        for (int i = bioma.Length - 1; i > 0; i--)
        {
            int rnd = Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overright when we swap the values
            GameObject temp = bioma[i];

            // Swap the new and old values
            bioma[i] = bioma[rnd];
            bioma[rnd] = temp;
            //Debug.Log("data = "+bioma[i]);

        }
    }

    public void suffleState(GameObject[] bioma)
    {
        int state = 6;
        for (int i = bioma.Length - 1; i > 0; i--)
        {

            // Save the value of the current i, otherwise it'll overright when we swap the values
            GameObject temp = bioma[i];

            // Swap the new and old values
            bioma[i] = bioma[state];
            bioma[state] = temp;


            state--;
        }
    }
    public void ToHome()
    {
        camKandang.SetActive(true);
        namaBioma.text = "Kandang";
    }
    public void ToBiome()
    {
        //suffleBioma(Biomas);
        Debug.Log("data = " + Biomas[0]);
        if (counter > 0)
        {
            Biomas[0].SetActive(true);
            namaBioma.text = Biomas[0].name.Substring(7);
            Biomas[1].SetActive(false); 
            Biomas[2].SetActive(false); 
            Biomas[3].SetActive(false); 
            Biomas[4].SetActive(false); 
            Biomas[5].SetActive(false); 
            Biomas[6].SetActive(false); 
            Biomas[7].SetActive(false); 
            camKandang.SetActive(false); 
            suffleState(Biomas);
        }
        counter--;
        scoretext.text = "";
    }
  

    void Update()
    {
     
    }
}
