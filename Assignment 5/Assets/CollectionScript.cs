using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collect") {
            Debug.Log("hit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
