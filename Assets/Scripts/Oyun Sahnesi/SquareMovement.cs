using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    public float h�z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, h�z * Time.deltaTime);
    }
}
