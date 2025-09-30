using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeatherTextDisplay : MonoBehaviour
{
    [Header("UI 텍스트 설정")]
    public TextMeshProUGUI temperatureText;  // TextMeshPro 텍스트 컴포넌트

    [Header("날씨 데이터")]
    public float currentTemperature = 25.0f;  // 현재 온도
    public string locationName = "Seoul";       // 지역 이름

    void Start()
    {
        // 게임 시작시 한번 실행
        Debug.Log("날씨 텍스트 시스템 시작!");

        // 텍스트가 연결되었는지 확인
        if (temperatureText == null)
        {
            Debug.LogError("TextMeshPro 컴포넌트가 연결되지 않았습니다!");
        }
        else
        {
            Debug.Log("텍스트 컴포넌트 연결 완료!");
        }
    }

    void Update()
    {
        // 매 프레임마다 실행 - 실시간 업데이트

        // 텍스트가 연결되어 있다면 업데이트
        if (temperatureText != null)
        {
            // 텍스트 내용 업데이트
            temperatureText.text = locationName + " current temperature: " + currentTemperature.ToString("F1") + "C";
        }
    }

    public void ChangeToSpring()
    {
        // 봄 설정값들
        currentTemperature = 15.0f;      // 봄 온도: 15도
        locationName = "Spring Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("봄으로 변경되었습니다! 온도: " + currentTemperature + "도");
    }

    public void ChangeToSummer()
    {
        // 봄 설정값들
        currentTemperature = 30.0f;      // 봄 온도: 15도
        locationName = "Summer Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("여름으로 변경되었습니다! 온도: " + currentTemperature + "도");
    }

    public void ChangeToAutumn()
    {
        // 봄 설정값들
        currentTemperature = 20.0f;      // 봄 온도: 15도
        locationName = "Autumn Seoul";       // 봄 테마 지역명

        // 디버그 메시지로 함수 실행 확인
        Debug.Log("가을으로 변경되었습니다! 온도: " + currentTemperature + "도");
    }
    
    public void ChangeToWinter()
    {
        // 봄 설정값들
        currentTemperature = 10.0f;      // 봄 온도: 15도
        locationName = "Winter Seoul";       // 봄 테마 지역명
        
        // 디버그 메시지로 함수 실행 확인
        Debug.Log("겨울으로 변경되었습니다! 온도: " + currentTemperature + "도");
    }
}