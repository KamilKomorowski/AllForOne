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

    public List<GameObject> Units;


    void Update()
    {
        //connet the int to the ui
        MoneyText.text = this.gameObject.name.ToString()+ " money: " + Money.ToString();
    }

/*    public void SpawnUnit()
    {
        foreach (var unit in Units)
        {
            if (Input.GetButtonDown("Mouse1"))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray))
                {
                    Instantiate(unit, transform.position, transform.rotation);
                    Debug.Log("spawn");
                }
            }
        }
    }*/
    


    //add units to the list that you got from store
    
    
}
