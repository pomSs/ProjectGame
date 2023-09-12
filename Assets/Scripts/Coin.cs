using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Player"))
        {
            Debug.Log("Coin x 1");
            gameObject.SetActive(false);

         PlayerController player = GameObject.FindObjectOfType<PlayerController>();
            player.AddScore();

        }

    }
}
