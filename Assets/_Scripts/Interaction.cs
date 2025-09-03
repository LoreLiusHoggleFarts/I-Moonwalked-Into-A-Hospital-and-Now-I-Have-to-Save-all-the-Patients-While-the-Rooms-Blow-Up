
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool openOptions;
    public GameObject optionCanvas;
    public GameObject interactMessage;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (openOptions && Input.GetKeyDown(KeyCode.E))
        {
            interactMessage.SetActive(false);
            optionCanvas.SetActive(true);
        }

        if (!openOptions)
        {
            optionCanvas.SetActive(false);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        openOptions = true;
        interactMessage.SetActive(true);
        Debug.Log("OnTriggerEnter2D");
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactMessage.SetActive(false);
        openOptions = false;
    }
    
}
