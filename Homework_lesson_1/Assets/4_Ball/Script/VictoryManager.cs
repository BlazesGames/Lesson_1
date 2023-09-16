using UnityEngine;

public class VictoryManager : MonoBehaviour
{
    private IVictory _victory;


    public void ChekVictory()
    {
        _victory.Victory();
    }

    public void ButAllBall()
    {
        SetVictory(new AllBallPattern());
    }

    public void ButColorBall()
    {
        SetVictory(new OneColorBallPattern());
    }

    private void SetVictory(IVictory victory)
    {
        _victory?.VictoryDisactive();
        _victory = victory;
        _victory.VictoryActive();
    }
}
