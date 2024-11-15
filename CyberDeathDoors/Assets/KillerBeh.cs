using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KillerBeh : MonoBehaviour
{

    
        
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollision(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
            Destroy(other.gameObject);

    }

}
      
