using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField]private TMP_Text text;

    [SerializeField] private PlayerController Player; 

    void Update()
    {
       
        text.text = Player.GetScore().ToString();
    }
}
