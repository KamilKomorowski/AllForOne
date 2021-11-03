using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public int Money = 100;

    public TMP_Text MoneyText;
    
    void Start()
    {
    }

    void Update()
    {

        MoneyText.text = this.gameObject.name.ToString()+ " money: " + Money.ToString();
    }
    
    
}
