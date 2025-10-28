using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    public float hýz;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, hýz * Time.deltaTime);
    }
}
