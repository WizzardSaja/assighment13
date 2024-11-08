using UnityEngine;
public class Player 
{
 public string playerName="";
 public int health =100;
 
 // Static field to keep track of the number of Player instances
public static int playerCount = 0;

public void InitializePlayer(string name, int initialHealth){

      playerName = name;
      health = initialHealth;
      playerCount++;
}

    public void Heal(int amount){

        health= health + amount;
         Debug.Log(playerName+" healed by"+ amount+ " Current health"+ health);
        //return (Debug.log(health);) ;
    }
      public void Heal(bool fullRestore)
    {
        if (fullRestore==true)
        {
            health = 100; // Assuming 100 is the maximum health
            Debug.Log(playerName+"'s health fully restored. Current health: "+ health);
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log("Total players: "+playerCount);
    }
  //  int ShowPlayerCount(){

  //      return Debug.log(PlayerCount);
   // }

}
 