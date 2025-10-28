using UnityEngine;

public class OyununSonlanması : MonoBehaviour
{
    public GameObject dönenBüyükÇember;
    public GameObject spawnLokasyonu;
    public void OyunuBitir()
    {
        dönenBüyükÇember.GetComponent<SquareMovement>().enabled = false;
        spawnLokasyonu.GetComponent<KüçükCubukSpawner>().enabled = false;
    }
}
