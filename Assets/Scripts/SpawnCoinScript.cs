using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoinScript : MonoBehaviour
{
    public GameObject theCoin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        gameObject.transform.Rotate(0f, 1f, 0f, Space.Self);
        
      
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.scoreCount += 1;
            
        }
    }

}
