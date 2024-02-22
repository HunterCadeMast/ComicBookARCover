using UnityEngine;

public class DualSprites : MonoBehaviour
{
    public GameObject sprite1Object;
    public GameObject sprite2Object;

    void Start()
    {
        // You can position each sprite object wherever you want
        sprite1Object.transform.position = new Vector3(-2f, 0f, 0f);
        sprite2Object.transform.position = new Vector3(2f, 0f, 0f);
    }
}