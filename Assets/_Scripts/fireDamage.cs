using UnityEngine;

public class fireDamage : MonoBehaviour
{
    Health health;
    [SerializeField] public float dmgFire;
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        health = collision.gameObject.GetComponent<Health>();

        Debug.Log(collision.gameObject.name);
        if (health != null)
        {
            health.currentHealth -= dmgFire;
        }
    }
    
}
