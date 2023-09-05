using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Coin"))
        {
            Debug.Log("Coin x 1");
            SceneManager.LoadScene(0);
        }

    }
}
