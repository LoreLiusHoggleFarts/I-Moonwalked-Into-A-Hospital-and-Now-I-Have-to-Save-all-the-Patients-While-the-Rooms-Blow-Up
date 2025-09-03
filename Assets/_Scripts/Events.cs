using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Events : MonoBehaviour
{
    public GameObject bomb;

    public GameObject fire;
    public Collider2D flameSpawnArea;
    
    private Rigidbody2D rb;
    
    private float xSpawnPoints;
    private float ySpawnPoints;
    
    public GameObject player;

    private float newSpawnX;
    private float newSpawnY;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (player.transform.position.x < transform.position.x)
        
            StartCoroutine("Bomb");
            xSpawnPoints = (flameSpawnArea.transform.position.x + (flameSpawnArea.bounds.size.x)) / 2;
            ySpawnPoints = (flameSpawnArea.transform.position.y + (flameSpawnArea.bounds.size.y)) / 2;
                        
            for (int i = 0; i < 6; i++)
            {
                newSpawnX = Random.Range(-xSpawnPoints, xSpawnPoints);
                newSpawnY = Random.Range(-ySpawnPoints, ySpawnPoints);
                Vector2 randomPosition = new Vector2(newSpawnX, newSpawnY);
                Instantiate(fire, randomPosition, Quaternion.identity);
            }
            
    }

    IEnumerator Bomb()
    {
        bomb.SetActive(true);
        yield return new WaitForSeconds(2f);
        bomb.SetActive(false);
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
  
    

    
    
}
