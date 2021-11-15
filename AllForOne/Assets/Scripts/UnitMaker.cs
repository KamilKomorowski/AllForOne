using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnitMaker : MonoBehaviour
{
    //get all players
    public List<Player> Players;
    public UnitStoreUI Store;
    
    [HideInInspector]
    public int CurrentPlayer = 0;

    public static UnitMaker instance { get; private set; }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //add the player to the player list
        foreach (var player in GameObject.FindGameObjectsWithTag("Player"))
        {
            Players.Add(player.GetComponent<Player>());
        }
            
        Store.SellTo(Players[CurrentPlayer]);
    }
}
