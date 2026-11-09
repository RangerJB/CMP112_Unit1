using UnityEngine;
using UnityEngine.UI;


public class Point_system : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    public Text PointText;

    void Update()
    {
        
        PointText.text = "Points: " +  Point_manager.Points;

    }
    
}
