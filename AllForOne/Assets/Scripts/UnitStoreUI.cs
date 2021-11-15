using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class UnitStoreUI : MonoBehaviour
{
    //read player[i] money
    // get all variables 
    //make unit
    public Player player;
    
    public GameObject store;

    public GameObject unit;

    public Slider Health;
    public Slider Strength;
    public Slider Speed;
    public Slider Defense;

    public Button btn;

    public GameObject Error;
    public TMP_Text MoneyUI;
    public TMP_Text SummaryUI;
    private int Money;
    private int Summary;

    public GameObject cube;

    

    public void SellTo(Player currentPlayer)
    {
        Money = currentPlayer.Money;
        //add +1 to currentplayer
    }

    public void NextPlayer()
    {
        UnitMaker.instance.CurrentPlayer += 1;
        SellTo(UnitMaker.instance.Players[UnitMaker.instance.CurrentPlayer]);
        CreateUnit(UnitMaker.instance.Players[UnitMaker.instance.CurrentPlayer]);
        //   player.SpawnUnit();
    }

    public void ShowError()
    {
        if (Money > Summary)
        {
            CreateUnit(UnitMaker.instance.Players[UnitMaker.instance.CurrentPlayer]);
            Money -= Summary;
        }
        else if (Money < Summary)
        {
            Error.SetActive(true);
        }
    }

    public void LetsFight()
    {
        store.SetActive(false);
    }

    public void CreateUnit(Player currentPlayer)
    {
        GameObject go = Instantiate(unit, new Vector3(0, 1,0), Quaternion.identity);
        UnitBehaviour u = go.GetComponent<UnitBehaviour>();
        u.unit = new Unit();
        u.Health = (int) Health.value;
        u.Strength = (int) Strength.value;
        u.Speed = (int) Speed.value;
        u.Defence = (int) Defense.value;
        currentPlayer.Units.Add(unit);
    }
    

    void Update()
    {
        MoneyUI.text = "Money: " + Money.ToString();
        SummaryUI.text = "Cost: " + Summary.ToString();
        Summary = (int) Health.value + (int) Strength.value + (int) Speed.value + (int) Defense.value;
        

    }
}
