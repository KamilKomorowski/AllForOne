using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit
{
    public int health;
    public int strength;
    public int speed;
    public int defence;

    public Unit(int health, int strength, int speed, int defence)
    {
        this.health = health;
        this.strength = strength;
        this.speed = speed;
        this.defence = defence;
    }

    public Unit()
    {
        this.health = 1;
        this.strength = 1;
        this.speed = 1;
        this.defence = 1;
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetStrength()
    {
        return strength;
    }

    public int GetSpeed()
    {
        return speed;
    }

    public int GetDefence()
    {
        return defence;
    }

}