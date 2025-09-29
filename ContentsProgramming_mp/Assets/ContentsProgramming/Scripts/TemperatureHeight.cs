using UnityEngine;

public class TemperatureHeight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float temperature = 25.0f;
    public float maxHeight = 5.0f;
    private Transform myTransform;
    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    void Update()
    {
        float height = (temperature / 50.0f) * maxHeight;
        myTransform.localScale = new Vector3(1, height, 1);
        Debug.Log("온도" + temperature + "도 -> 높이" + height);
    }

}
