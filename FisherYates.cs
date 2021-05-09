using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisherYates : MonoBehaviour
{
    

    public void Suffle<T>(T[] Array) 
    {
        for (int i=Array.Length;i>1; i--) 
        {
            int j = Random.Range(0, Array.Length);
            T temp = Array[j];
            Array[j] = Array[i - 1];
            Array[i - 1] = temp;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
