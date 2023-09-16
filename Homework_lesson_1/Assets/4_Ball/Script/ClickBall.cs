using UnityEngine;

public class ClickBall : MonoBehaviour
{
    public int numColor; //0 - �����, 1 - �������, 2 - �������
    [SerializeField] private VictoryManager victoryManager;
    public static int numColorBall = 10;//�������� �� �������� ����� �������� �� ����� �����
    

    private void Start()
    {
        AllBallPattern.AllBall.Add(this); 
    }

    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //���� ������ �� 10, ���� ������� ��� ������� �����, �� 11
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
