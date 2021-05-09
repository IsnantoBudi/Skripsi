using System.Collections.Generic;
using UnityEngine;
using System;
using System.Collections;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
	public static Item instance;

	public GameObject[] hewan = new GameObject[10];
	public int jumlahHewanDitampilkan;
	public int objectQuantity;
	public int xPos;
	public int zPos;

	

	
	Item[] array = new Item[5];
	public GameObject[] ObjectHewan = new GameObject[5];
	new public string name = "New Item";    // Name of the item
    public Sprite icon = null;              // Item icon
    public bool isDefaultItem = false;


	public GameObject Object;

	void Awake()
	{
		instance = this;
	}
	public virtual void Use()
	{
		
		array = Inventory.instance.items.ToArray();

        hewan = InventorySlot.instance.hewan;
		}

    
}
