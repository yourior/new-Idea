using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBall : MonoBehaviour {

    public int RollSpeed;
    public Rigidbody rb;
    public int chargespeed;
    public bool charge;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        charge = false;
        chargespeed = 1;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 Roll = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(Roll * (RollSpeed*chargespeed));
        
            if(Input.GetKey(KeyCode.Space))
            {
                chargespeed = RollSpeed * 100;
                charge = true;
            }
           
        
      
       

    }
}
