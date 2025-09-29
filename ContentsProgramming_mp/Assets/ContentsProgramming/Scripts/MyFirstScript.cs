using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start는 게임 시작할 때 한 번 실행됩니다
    public int playerLevel = 1;
    public float walkSpeed = 5.0f;
    public string playerName = "김철수";
    public bool canJump = true;
    void Start()
    {
        Debug.Log("플레이어 레벨: " + playerLevel);
        Debug.Log("걸음 속도: " + walkSpeed + "m/s");
        Debug.Log("플레이어 이름: " + playerName);
        Debug.Log("점프 가능: " + canJump);
       
    }
}
