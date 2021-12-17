using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamra : MonoBehaviour
{


    // Start is called before the first frame update
    //this camrea shold be as the position of the car     

    [SerializeField] GameObject thingtoFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=thingtoFollow.transform.position+ new Vector3(0,0,-10);
        
    }
}
