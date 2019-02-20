using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    public Animator Ani;
    // Start is called before the first frame update
    void Start()
    {
        Ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Ani.Play("Up");
    }
    public void Up()
    {
        Ani.Play("Up");
    }
}
