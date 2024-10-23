using System;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public GameObject directionLight;

    private Transform lightTransform;
    private Transform camTransform;
    void Start()
    {

        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        // directionLight = GameObject.Find("Directional Light");
        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
        
        // Weapon desertEagle = new Weapon("Desert Eagle", 47);
        // Paladin knight = new Paladin("Sir Arthur", desertEagle);
        // knight.PrintStatsInfo();

        // Character hero = new Character("Agatha");
        // hero.PrintStatsInfo();

        // Weapon huntingBow = new Weapon("Hunting Bow", 105);
        // Weapon warBow = huntingBow;

        // warBow.name = "Desert Eagle";
        // warBow.damage = 47;

        // huntingBow.PrintWeaponStats();
        // warBow.PrintWeaponStats();

        // hero.PrintStatsInfo();

        // hero.Reset();

        
        
    }
}
