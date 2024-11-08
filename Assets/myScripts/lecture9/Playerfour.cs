using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfour : Character
{
    public Playerfour(string name, int health) : base(name, health) { }
    public void heal(int amount)
    {
        Health = Health + amount;
        UnityEngine.Debug.Log(Name + " healed by " + amount + ". Current health: " + Health);
    }



}
