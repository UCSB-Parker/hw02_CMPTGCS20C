using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = new Vector2(5,0); 
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D other) { 
       if (other.tag != "Player") {
          Destroy(other.gameObject);
          Destroy(gameObject);
       }
    }

} 
