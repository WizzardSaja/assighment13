using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
public string name="Saja";
private int health= 100;
    public string Name{
        get{ return name; }
        set{ name = value; }

    }
    public int Health{
        get{ return health; }
       set
        {
            // التأكد من أن الصحة لا تتجاوز 100
            if (value > 100)
                health = 100;
            else if (value < 0)
                health = 0;
            else
                health = value;
        }

    }
    public Character (string playername,int playerhealth){
        this.name = playername;
        this.health = playerhealth;
    }
   

  
}
