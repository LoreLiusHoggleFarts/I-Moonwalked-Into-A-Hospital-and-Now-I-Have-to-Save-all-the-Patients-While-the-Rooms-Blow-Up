using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class patientFollow : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform player;
    [SerializeField] private float patientSpeed;
    private bool canMove = false;
    [SerializeField] private float offset;
    public Vector3 followPoint;
    public Vector3 directionToPlayer;
    private Health health;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        health = player.GetComponent<Health>();
    }

    void Update()
    {
        if (canMove && health.currentHealth > 0)
        {
            directionToPlayer = (player.position - transform.position).normalized * offset;
            followPoint = player.position - directionToPlayer;
            
            
            transform.position = Vector2 .MoveTowards(transform.position, followPoint, patientSpeed * Time.deltaTime);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player");
        canMove = true;
        patientCount.instance.AddPatient(gameObject);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(followPoint, 0.2f);
    }
}
