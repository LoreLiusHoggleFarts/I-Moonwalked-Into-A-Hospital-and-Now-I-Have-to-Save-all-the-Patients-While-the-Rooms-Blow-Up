using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject objects;
    void Awake()
    {
        objects.SetActive(false);
    }
}
