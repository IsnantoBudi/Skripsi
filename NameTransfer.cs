using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{
    public string TheName;
    public GameObject Input;
    public Text InputField;
    public GameObject DisplayName;
    public GameObject Button;
    public GameObject UI;
    public Text transferNama;
    public void NameStore()
    {
        /*if (transferNama.text != "")
        {
            Button.active = false;
            Input.GetComponent<Renderer>();
            Input.active = false;
            UI.SetActive(true);
 
            Debug.Log(" nama T= " + transferNama.text);
        }
        else */if(InputField.GetComponent<Text>().text.ToString() != "") 
        {
            TheName = InputField.GetComponent<Text>().text;
            DisplayName.GetComponent<Text>().text = " " + TheName;

            
            Button.active = false;
            Input.GetComponent<Renderer>();
            Input.active = false;
            UI.SetActive(true);
            //transferNama.text = DisplayName.GetComponent< Text > ().text ;
            //Debug.Log(" nama = " + transferNama.text);
        }
        else
        {
            Button.active = true;
            Input.GetComponent<Renderer>();
            Input.active = true;
        }
        
    }
 
}
