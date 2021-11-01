using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
  
    [SerializeField] float desPackDelay = 0.1f;

    [SerializeField] Color32 hasPackageColor= new Color32(255, 255, 255, 255);

    [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

    [SerializeField] int GameWonScn;

    GameObject CustExist;

    void Update()
    {
      CustExist = GameObject.FindWithTag("Customer");

      if(CustExist == null)
      {
        SceneManager.LoadScene(GameWonScn);
      }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
      Debug.Log("BAM YA HIT SOMETHIN");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
      if(other.tag == "Package" && hasPackage == false)
      {
        Debug.Log("Package picked up");
        
        hasPackage = true;

        Destroy(other.gameObject, desPackDelay);

      }

      if(other.tag == "Customer" && hasPackage == true)
      {
        Debug.Log("Package dropped off");

        hasPackage = false;

        Destroy(other.gameObject, desPackDelay);
      }

    }
}
