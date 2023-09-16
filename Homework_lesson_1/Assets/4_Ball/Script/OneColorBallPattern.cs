using UnityEngine;

public class OneColorBallPattern : IVictory
{
    private bool isActive;
    public static int countClick = 5;

    public void Victory()
    {
        if(countClick == 0 && ClickBall.numColorBall != 11)
        Debug.Log("Вы лопнули шарики одного цвета и одержали победу");
    }



    public void VictoryActive() => isActive = true;
    public void VictoryDisactive() => isActive = false;

    //public void SetapBallColor(int numColor)
    //{
    //    if (numColor == 0)
    //        countWhitBall++;
    //    else if (numColor == 1)
    //        countRedBall++;
    //    else if (numColor == 2)
    //        countGreenBall++;
    //}

}
