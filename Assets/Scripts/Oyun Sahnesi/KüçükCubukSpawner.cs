using UnityEngine;

public class KüçükCubukSpawner : MonoBehaviour
{
    public GameObject kucukÇubuk;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            kucukCubukSpawner();
        }
    }

    void kucukCubukSpawner()
    {
        Instantiate(kucukÇubuk, transform.position, transform.rotation);
    }
}
