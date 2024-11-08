using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player n1 = new Player();
        Player n2 = new Player();
        n1.InitializePlayer("saja", 70);
        n2.InitializePlayer("Abood", 60);

        n1.Heal(90);
        n2.Heal(true);
        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
