using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet") {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 temp = target.position;
        temp.y = target.position.y + 1;
        transform.position = Vector3.MoveTowards(transform.position, temp, 2*Time.deltaTime);

    }
}
