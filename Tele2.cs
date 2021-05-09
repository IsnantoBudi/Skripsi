using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tele2 : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject ThePlayer;

    private void OnTriggerEnter(Collider other)
    {
        ThePlayer.transform.position = teleportTarget.transform.position;
    }
}
