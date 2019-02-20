using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScriptOrb : MonoBehaviour
{
    public GameObject thing;
    Animation Ani; 
    // Start is called before the first frame update
    void Start()
    {
        Ani = GetComponent<Animation>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            
            Debug.Log("Abouta do the thing");
            Destroy(gameObject);
            Instantiate(thing, transform.position, transform.rotation);
            GameObject.Find("Door").GetComponent<DoorMove>().Up();
            
        }
    }
// Update is called once per frame
    void Update()
    {
        
    }
}
