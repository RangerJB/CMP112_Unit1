using UnityEngine;

public class Points_script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("point collected");
            Point_manager.AddPoints();
            Destroy(gameObject);
            
        }
    }
}
