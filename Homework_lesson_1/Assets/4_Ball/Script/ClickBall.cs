using UnityEngine;

public class ClickBall : MonoBehaviour
{
    public int numColor; //0 - белый, 1 - красный, 2 - зеленый
    [SerializeField] private VictoryManager victoryManager;
    public static int numColorBall = 10;//отвечает за проверку какой сменился ли номер цвета
    

    private void Start()
    {
        AllBallPattern.AllBall.Add(this); 
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //если пустая то 10, если лопнули шар другого цвета, то 11
            if (numColorBall == 10)
            {
                numColorBall = numColor;
            }
            else if(numColorBall != 10 && numColorBall != numColor)
            {
                numColorBall = 11;
            }

            OneColorBallPattern.countClick--;
            AllBallPattern.AllBall.Remove(this);
            victoryManager.ChekVictory();
            Destroy(gameObject);
        }
    }
}
