using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }

    public void Attack(int amount)
    {
        Health = Health - amount;
        UnityEngine.Debug.Log(Name + " attacked target with " + amount);

    }



}
