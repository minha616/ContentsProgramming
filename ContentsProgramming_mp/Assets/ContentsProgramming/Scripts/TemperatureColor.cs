using UnityEngine;

public class TemperatureColor : MonoBehaviour
{
    public float temperature = 20.0f;
    public Color coldColor = Color.blue;
    public Color normalColor = Color.green;
    public Color hotColor = Color.red;
    private Renderer myRenderer;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (temperature < 15.0f)
        {
            myRenderer.material.color = coldColor;
            Debug.Log("차가운 색상으로 변경됨: " + coldColor);
        }
        else if (temperature < 30.0f)
        {
            myRenderer.material.color = normalColor;
            Debug.Log("보통 색상으로 변경됨: " + normalColor);

        }
        else
        {
            myRenderer.material.color = hotColor;
            Debug.Log("뜨거운 색상으로 변경됨 " + hotColor);
        }
    }



}
