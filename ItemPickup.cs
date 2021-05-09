using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : InteracTable
{
    public static ItemPickup instance;
    public Item item;
    public GameObject Object;
    public List<GameObject> HewanObject = new List<GameObject>();
    public GameObject[] ArrayHewan = new GameObject[5];

    public override void Interact()
    {
        base.Interact();

        PickUp();

       // HewanToList();
    }

    // Pick up the item
    public void PickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickup = Inventory.instance.Add(item);   // Add to inventory

        if (wasPickup)
        {
            //for (int i = 0; i < HewanObject.Length; i++)
            //{
                Object = gameObject;
                gameObject.GetComponent<Renderer>();

               // HewanObject[i] = Object;
               // Debug.Log("item telah di masukkan ke object" + HewanObject[i]);


                Object = gameObject;
                 HewanObject.Add(Object);
            ArrayHewan = HewanObject.ToArray();
            Destroy(gameObject);    // Destroy item from scene
            
        }

    }
    public void HewanToList()
    {
        if(Object.active = false)
        {

            HewanObject.Add(Object);
            
        }
    }
}
