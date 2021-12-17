using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    //SerializeField will show the float in the unity screen
    [SerializeField]float steerSpeed=1f;
   [SerializeField] float moveSpeed=10f;

    [SerializeField]float fastSpeed=30f;

    [SerializeField]float slowSpeed=14f;

    // Start is called before the first frame update
    

    

    // Update is called once per frame
    void Update()
    {
        //make the user use the keybored
        // forewd and backwored and right and left
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float steerways = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime    ;
         
        //roatate in place
         transform.Rotate(0,0,-steerAmount);
         //move forwored
         transform.Translate(0,steerways,0);


    }


    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag=="speedup"){
            moveSpeed=fastSpeed;
          
        }


    }

    private void OnCollisionEnter2D(Collision2D other) {
        
        moveSpeed=slowSpeed;
        
    }
}
