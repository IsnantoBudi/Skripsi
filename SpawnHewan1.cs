using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnHewan1 : MonoBehaviour
{
    //public GameObject beruang, rusa, serigala, buaya, kepiting, salamander, babi;
    /*public GameObject rusa;
    public GameObject serigala;
    public GameObject buaya;
    public GameObject kepiting;
    public GameObject salamander;
    public GameObject babi;*/
    public int xPos;
    public int zPos;
    //public int objectToGenerate;
    public int objectQuantity;
    public int jumlahHewanDitampilkan;
    //public int[] hasil ;
    public GameObject[] hewan;



    //public int[] scenarios = new int[] { 1, 2, 3, 4, 5, 6, 7 };


    void Start()
    {
        Shuffle(hewan);
        StartCoroutine(GenerateObject());
        
    }
   
    void Shuffle(GameObject[] hewan)
    {
        // Loops through array
        for (int i = hewan.Length - 1; i > 0; i--)
        {
           int rnd = Random.Range(0, i);

            // Save the value of the current i, otherwise it'll overright when we swap the values
            GameObject temp = hewan[i];

            // Swap the new and old values
            hewan[i] = hewan[rnd];
            hewan[rnd] = temp;
        }

        // Print
        //for (int i = 0; i < a.Length; i++)
        //{
            // hasil[i] = a[i];
        //    Debug.Log(a[i]);
        //}
    }
    IEnumerator GenerateObject()
    {
        while (objectQuantity < jumlahHewanDitampilkan)
        {
            xPos = Random.Range(347, 360);
            zPos = Random.Range(-28, -27);
            Instantiate(hewan[objectQuantity], new Vector3(xPos, 11, zPos), Quaternion.identity);


            /*objectToGenerate = scenarios[objectQuantity];
            xPos = Random.Range(347, 360);
            zPos = Random.Range(-36, -33);
            Instantiate(hewan[objectToGenerate-1], new Vector3(xPos, 11, zPos), Quaternion.identity);

            if (objectToGenerate == 1)
            {
                Instantiate(beruang, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 2 ) 
            {
                Instantiate(rusa, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 3 )
            {
                Instantiate(serigala, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 4)
            {
                Instantiate(buaya, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 5)
            {
                Instantiate(kepiting, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 6)
            {
                Instantiate(salamander, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }
            if (objectToGenerate == 7)
            {
                Instantiate(babi, new Vector3(xPos, 11, zPos), Quaternion.identity);
            }*/
            yield return new WaitForSeconds(0.1f);
            objectQuantity += 1;
        }
    } 
}
