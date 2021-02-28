using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject creature0;
    float timer = 0f;
 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(creature0, new Vector3(0,0,0), Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
       timer += Time.deltaTime; 
         if (timer >= 2)
         {
             Instantiate(creature0, new Vector3(0, 0, 0), Quaternion.identity);
             timer = 0f;
         }
        
    }
}
