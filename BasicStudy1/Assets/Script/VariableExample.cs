using UnityEngine;

public class VariableExample : MonoBehaviour
{
    //���� ����
    public int playerscore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameover = false;





    void Start()
    {
        //�������
        Debug.Log("player Name : " + playerName);
        Debug.Log("player score : " + playerscore);
        Debug.Log("speed : " + speed);
        Debug.Log("Is Game Over? : " + isGameover);
    }

    

}
