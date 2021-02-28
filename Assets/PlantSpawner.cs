using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawner : MonoBehaviour
{

    public GameObject phase1;
    public GameObject phase2;
    public GameObject phase3;
    bool p1 = true;
    bool p2 = true;
    bool p3 = true;
    public GameObject[] killEmAll0;
    public GameObject[] killEmAll1;
    public GameObject[] killEmAll2;
    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
      /*
      killEmAll2 = GameObject.FindGameObjectsWithTag("plant1");
           for(int i = 0; i < killEmAll2.Length; i++){
              Destroy(killEmAll2[i].gameObject);
          }   
      */
    }

    // Update is called once per frame
    void Update()
    {
       timer += Time.deltaTime;
       /*
       if (timer >= 10 && p1 == true){
          Instantiate(phase1, new Vector3(-3.2f, 0, 0), Quaternion.identity);
          p1 = false;
         }
       */
       if (timer >= 20 && p2 == true) {
           killEmAll0 = GameObject.FindGameObjectsWithTag("plant1");
           for(int i = 0; i < killEmAll0.Length; i++){
              Destroy(killEmAll0[i].gameObject);
          }
          Instantiate(phase2, new Vector3(-3.2f, 0, 0), Quaternion.identity);
          p2 = false;
       }
       else if (timer >= 30 && p3 == true) {
         killEmAll1 = GameObject.FindGameObjectsWithTag("plant2");
         for(int i = 0; i < killEmAll1.Length; i++){
              Destroy(killEmAll1[i].gameObject);
          }
          Instantiate(phase3, new Vector3(-3.2f, 0, 0), Quaternion.identity);
          p3 = false;
       }
       

    }

}
