using UnityEngine;

public class WeatherData : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float temperature = 30.0f;
    public float humidity = 100.0f;
    public string weatherType = "ㅈㄴ 더움";
    public bool isRaining = true;

    void Start()
    {
        Debug.Log("현재 온도: " + temperature + "도");
        Debug.Log("현재 습도: " + humidity + "%");
        Debug.Log("날씨 상태: " + weatherType);

        if(isRaining)
        {
            Debug.Log("비가 오고 있습니다!");
        }
        else
        {
            Debug.Log("비가 오지 않습니다.");
        }
    }

}