using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour 
{
    public static InventorySlot instance;
    public Image icon;
    public Button removeButton; // Reference to the remove button
    public Text scoreText;

    public GameObject[] hewan;
   // Item[] arrayHewan = new Item[5];
    public GameObject[] bioma;
    public int jumlahHewanDitampilkan;
    public int objectQuantity;
    public int xPos;
    public int yPos;
    public int zPos;
    int nyawa;
    int temp = 6;
    bool aktif = false;
    string contoh = "";
    public bool start = true;
   // Score score;
    Health health;
    Score score;
    
    int lokasiHewan;
    Item item;
    void Awake()
    {
        instance = this;
    }
    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        //removeButton.interactable = true;

    }

    private void Update()
    {

        if (item == null)
        {
            health = Health.instance;
            health.GameOver();
            
        }
        if(aktif)
        {
            temp = Inventory.instance.items.Count;
            Debug.Log("temp : " + temp);
            if (item == null)
            {
                health = Health.instance;
                nyawa = health.health;
                Debug.Log("nyawa "+nyawa);
                if (temp <= 0 && nyawa >0)
                {
                    score = Score.instance;
                    start = false;
                    score.HitungScore();
                }
                
            }
        }
        
    }
    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }
    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);
    }
    public void UseItem()
    {
        if (item != null)
        {
            StartCoroutine(GenerateObject(item));
            //PencocokanHewan(contoh, lokasiHewan);
            aktif = true;
            
        }
        
        else
        {
            Debug.Log("Enetekkkkk");
            if (temp <=0 && nyawa >= 0)
            {
                score = Score.instance;
                start = false;
                score.HitungScore();
            }


        }
      

    }
    IEnumerator GenerateObject(Item items)
    {
        //arrayHewan  = Inventory.instance.items.ToArray();
        
        Debug.Log("item = " + items);
        if (bioma[0].active == true) // Bioma Sabana
        {
            xPos = Random.Range(149, 142);
            yPos = 11;
            zPos = 690;
        }
        else if (bioma[1].active == true)// Bioma Gugur
        {
            xPos = Random.Range(563, 567);
            yPos = 14;
            zPos = 669;
        }
        else if (bioma[2].active == true)//Bioma Tundra
        {
            xPos = Random.Range(564, 556);
            yPos = 11;
            zPos = 82;
        }
        else if (bioma[3].active == true)//Bioma bakau
        {
            xPos = Random.Range(150, 146);
            yPos = 11;
            zPos = 492;
        }
        else if (bioma[4].active == true)// Bioma Taiga
        {
            xPos = Random.Range(125, 122);
            yPos = 11;
            zPos = 231;
        }
        else if (bioma[5].active == true) // Bioma tropis
        {
            xPos = Random.Range(562, 556);
            yPos = 11;
            zPos = 284;
        }
        else if (bioma[6].active == true) // Bioma Stepa
        {
            xPos = Random.Range(550, 543);
            yPos = 11;
            zPos = 491;
        }
        else if (bioma[7].active == true) // Bioma Gurun
        {
            xPos = Random.Range(149, 142);
            yPos = 11;
            zPos = 99;
        }

        if (items.name == "beruang")
            {
            PencocokanHewan("beruang", zPos);
                Instantiate(hewan[0], new Vector3(xPos, yPos, zPos), Quaternion.identity);
                //Debug.Log("beruang ");
                Inventory.instance.Remove(item);
            
            }
            else if (items.name == "kepiting")
            {
            PencocokanHewan("kepiting", zPos);
            Instantiate(hewan[1], new Vector3(xPos, yPos, zPos), Quaternion.identity);
                //Debug.Log("kepiting ");
                Inventory.instance.Remove(item);
            }
            else if (items.name == "buaya")
            {
            PencocokanHewan("buaya", zPos);
            Instantiate(hewan[2], new Vector3(xPos, yPos, zPos), Quaternion.identity);
                //Debug.Log("beruang ");
                Inventory.instance.Remove(item);
            }
            else if (items.name == "rusaJantan")
            {
            PencocokanHewan("rusaJantan", zPos);
            Instantiate(hewan[3], new Vector3(xPos, yPos, zPos), Quaternion.identity);
                //Debug.Log("rusaJantan ");
                Inventory.instance.Remove(item);
            }
            else if (items.name == "rusaBetina")
            {
            PencocokanHewan("rusaBetina", zPos);
            Instantiate(hewan[4], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("rusaBetina ");
            Inventory.instance.Remove(item);
            }
            else if (items.name == "salamander")
            {
            PencocokanHewan("salamander", zPos);
            Instantiate(hewan[5], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("salamander ");
            Inventory.instance.Remove(item);
            }
            else if (items.name == "babi")
            {
            PencocokanHewan("babi", zPos);
            Instantiate(hewan[6], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("babi ");
            Inventory.instance.Remove(item);
            }
            else if (items.name == "kelinci")
            {
            PencocokanHewan("kelinci", zPos);
            Instantiate(hewan[7], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("kelinci ");
            Inventory.instance.Remove(item);
            }
            else if (items.name == "serigala")
            {
            PencocokanHewan("serigala", zPos);
            Instantiate(hewan[8], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("serigala ");
            Inventory.instance.Remove(item);
            }
            else if (items.name == "kalajengking")
            {
            PencocokanHewan("kalajengking", zPos);
            Instantiate(hewan[9], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("kalajengking ");
            Inventory.instance.Remove(item);
            }
        else if (items.name == "badak")
        {
            PencocokanHewan("badak", zPos);
            Instantiate(hewan[12], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("badak ");
            Inventory.instance.Remove(item);
        }
        else if (items.name == "gajah")
        {
            PencocokanHewan("gajah", zPos);
            Instantiate(hewan[10], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("gajah ");
            Inventory.instance.Remove(item);
        }
        else if (items.name == "singa")
        {
            PencocokanHewan("singa", zPos);
            Instantiate(hewan[11], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("singa ");
            Inventory.instance.Remove(item);
        }
        else if (items.name == "zebra")
        {
            PencocokanHewan("zebra", zPos);
            Instantiate(hewan[13], new Vector3(xPos, yPos, zPos), Quaternion.identity);
            //Debug.Log("zebra ");
            Inventory.instance.Remove(item);
        }

        yield return new WaitForSeconds(0.1f);

            //Debug.Log("item array = "+Item);
        
        
    }
    public void PencocokanHewan(string Hewan, int lokasi)
    {
        scoreText.color = Color.green;
        // if (Hewan == GameObject.Find("beruang").ToString())
        // {
        temp=temp-1;
        if (Hewan == "badak")
        {
            if (lokasi != 690 && lokasi != 491 && lokasi != 284) // sabana  & stepa
            {

                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";

            }
        }
        if (Hewan == "gajah")
        {
            if (lokasi != 690 && lokasi != 491) // sabana  & stepa
            {

                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";

            }
        }
        if (Hewan == "singa")
        {
            if (lokasi != 690 && lokasi != 491) // sabana  & stepa
            {

                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";

            }
        }
        if (Hewan == "zebra")
        {
            if (lokasi != 690 && lokasi != 491) // sabana  & stepa
            {

                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";

            }
        }
        if (Hewan == "beruang")
            {
                if (lokasi != 284 ) // tropis
                {
                    
                    health = Health.instance;
                    health.MinusNyawa();
               
                }
            else {
                scoreText.text = "selamat anda benar";
            
            }
            }
        if (Hewan == "kepiting")
            {
                if (lokasi != 492) // bakau
                {
                   
                    health = Health.instance;
                    health.MinusNyawa();
                }
            else
            {
                scoreText.text = "selamat anda benar";
             
            }
        }
        if (Hewan == "buaya")
        {
            if (lokasi != 492) // bakau
            {
                
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
           
            }
        }
        if (Hewan == "rusaJantan")
        {
            if (lokasi != 690 && lokasi != 284) // sabana & tropis
            {
                
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
             
            }
        }
        if (Hewan == "rusaBetina")
        {
            if (lokasi != 690 && lokasi != 284) // sabana &tropis
            {
               
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
                
            }
        }
        if (Hewan == "salamander")
        {
            if (lokasi != 492) // bakau
            {
                
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
              
            }
        }
        if (Hewan == "babi")
        {
            if (lokasi != 284 ) // tropis 
            {
               
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
             

            }
        }
        if (Hewan == "kelinci" )
        {
            if (lokasi != 690 && lokasi != 491) // sabana  & stepa
            {
                
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
                
            }
        }
        if (Hewan == "serigala")
        {
            if (lokasi != 231 && lokasi != 82) // taiga & tundra
            {
               
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {
                scoreText.text = "selamat anda benar";
                
            }
        }
        if (Hewan == "kalajengking")
        {
            if (lokasi != 99 && lokasi != 284) // gurun & tropis
            {
               
                health = Health.instance;
                health.MinusNyawa();
            }
            else
            {   
                scoreText.text = "selamat anda benar";
                
                
            }
        }

       

    }
}
