using System;
using UnityEngine;

public class Paladin: Character
{
    public Weapon weapon;
    public Paladin(String name, Weapon weapon): base(name) 
    {
        this.weapon = weapon;
    }

    public override void  PrintStatsInfo()
    {
        Debug.LogFormat("Name Paladin is: {0} he has weapon with name {1}",  name, weapon.name);
    }  
}