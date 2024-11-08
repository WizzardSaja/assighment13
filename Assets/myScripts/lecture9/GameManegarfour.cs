using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManegarfour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Playerfour p1 = new Playerfour("ss", 33);
        Enemy e1 = new Enemy("aa", 26);
        p1.heal(50);
        e1.Attack(40);
    }


}
