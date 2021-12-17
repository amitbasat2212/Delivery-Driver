using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilivery : MonoBehaviour
{
    [SerializeField] Color32 HasPackedColor=new Color32(1,1,1,1);
    [SerializeField] Color32 noPackgeColor=new Color32(1,1,1,1);
    SpriteRenderer spriteRenderer;
   
    [SerializeField] float DestroyDelay=0.5f;

    bool HasPackeged=false;

    
    private void Start() {
        
        spriteRenderer=GetComponent<SpriteRenderer>();
    }
   
    public void OnCollisionEnter2D(Collision2D other) {

        //how to print 
        Debug.Log("hi");


    }

    private void OnTriggerEnter2D(Collider2D other) {
        //statmet acording to conditions for the pakeges and their deasaperens
        if(other.tag=="Packge" && !HasPackeged){
           Debug.Log("packge picked up");     
           HasPackeged=true;
           Destroy(other.gameObject,DestroyDelay);
           spriteRenderer.color=noPackgeColor;
        }
         if(other.tag=="customer" && HasPackeged){
           HasPackeged=false;  
           Debug.Log("diliverd packge");  
          spriteRenderer.color=HasPackedColor;

        }
    }
}
