using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    //set the money of the each player
    public int Money = 100;
    public TMP_Text MoneyText;
    
    void Start()
    {
    }

    void Update()
    {
        //connet the int to the ui
        MoneyText.text = this.gameObject.name.ToString()+ " money: " + Money.ToString();
    }
    
    
    //instatiet unit
    
    
}
