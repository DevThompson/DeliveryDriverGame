using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float driverSpeed = 20.0f;
    [SerializeField] float turnSpeed = 200.0f;
    [SerializeField] float slowSpeed = 15.0f;
    [SerializeField] float boostSpeed = 30.0f;
    [SerializeField] float desPackDelay = 0.1f;
    [SerializeField] Sprite carSprite;


    // Update is called once per frame
    void Update()
    {
        float driveSpd = Input.GetAxis("Vertical") * driverSpeed * Time.deltaTime;
        float turnSpd = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
          
        transform.Rotate(0, 0, -turnSpd);

        transform.Translate(0, driveSpd, 0);
    
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        driverSpeed = slowSpeed;  
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
      if (other.tag == "Boost") 
      {
        driverSpeed = boostSpeed; 

        Destroy(other.gameObject, desPackDelay);
      } 
    }
}
