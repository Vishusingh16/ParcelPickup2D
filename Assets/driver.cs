using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  driver : MonoBehaviour
{
    // Start is called before the first frame update

      [SerializeField]float steerSpeed =1f; //serializeFeild is used for overrding the value as displayed in inspector panel
      [SerializeField]float moveSpeed =20f;
        [SerializeField]float slowSpeed =15f; 
          [SerializeField]float boostSpeed =30f; 

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveAmount  = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);  
        transform.Translate(0,moveAmount,0);  
    }
    void OnCollisionEnter2D(Collision2D other){
      moveSpeed = slowSpeed;
      
    }
    void OnTriggerEnter2D(Collider2D other){
      if(other.tag=="Boost"){
      moveSpeed =boostSpeed;
      }
    }
}
