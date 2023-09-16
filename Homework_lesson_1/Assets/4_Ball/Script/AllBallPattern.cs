using System.Collections.Generic;
using UnityEngine;

public class AllBallPattern : IVictory
{
    private bool isActive;
    public static List<ClickBall> AllBall = new List<ClickBall>();


    public void Victory()
    {

        if (AllBall.Count == 0)
            Debug.Log("¬ы лопнули все шары и одержали победу");
    }

    public void VictoryActive() => isActive = true;
    public void VictoryDisactive() => isActive = false;
}
