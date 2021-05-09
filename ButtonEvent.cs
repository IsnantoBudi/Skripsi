using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
	public GameObject menu;
	public GameObject carabermain;
	public GameObject penilaian;
	public void playGame(){
	  Application.LoadLevel("Loading");
	}

	public void toMenu(){
	  Application.LoadLevel("menu");
	}
	public void toQuit(){
	  Application.Quit();
	}
	public void toShowmenu()
    {
		menu.SetActive(true);
		penilaian.SetActive(false);
		carabermain.SetActive(false);

	}
	public void toPenilaian()
	{
		penilaian.SetActive(true);
		menu.SetActive(false);
	}
	public void toPenjelasan()
	{
		carabermain.SetActive(true);
		menu.SetActive(false);
	}

}
