using System;
using UnityEngine;

public class Character 
{
    
    public String name;

    public int exp = 0;

    public Character() 
    {
        name = "Not assigned";
    }

    public Character(String name) 
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }

    private void Reset() 
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

public struct Weapon 
{
    public String name;
    public int damage;

    public Weapon(String name, int damage) 
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", name, damage);
    }
}
