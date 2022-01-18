using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text value;
    public int point;

    void UpdatePoint()
    {
        value.text = point.ToString();
    }

    public void AddPoint(int value)
    {
        point += value;
        UpdatePoint();
    }

    void Start() 
    {
        UpdatePoint();
    }
}
