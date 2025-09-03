
using UnityEngine;

public class invertScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject interaction;
    public GameObject invert;
    private bool interactionMessage;
    public bool canInvertControls;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (interactionMessage && Input.GetKeyDown(KeyCode.E))
        {
            interaction.SetActive(false);
            invert.SetActive(true);
            canInvertControls = true;
        }
        

        if (!interactionMessage)
        {
            invert.SetActive(false);
        }

        if (canInvertControls)
        {
            
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interaction.SetActive(true);
        interactionMessage = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interaction.SetActive(false);
        interactionMessage = false;
        Debug.Log(collision.gameObject.name);
    }

    
    
}
