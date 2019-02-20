using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 positionUpdate;
    CharacterController CController;
    private Animator Anim; 
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        CController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float moveMult = 10F;
        int moving = 2;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            transform.position += transform.forward * Time.deltaTime * moveMult;
            moving = 0;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            transform.position -= transform.forward * Time.deltaTime * moveMult;
            moving = 1;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            transform.position -= transform.right * Time.deltaTime * moveMult;
            moving = 0;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            transform.position += transform.right * Time.deltaTime * moveMult;
            moving = 0;
        }
        if (moving == 0) {
            Anim.SetTrigger("Run");
        } else if (moving==1) {
            Anim.SetTrigger("Backwards");
        } else {
            Anim.SetTrigger("Idle");
        }
        //transform.position += transform.down * moveMult * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(new Vector3(0, -2, 0));
        }
        if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(new Vector3(0, 2, 0));
        }
    }
}
