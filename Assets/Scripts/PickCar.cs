using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCar : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject DelCar;

    void Start() 
    {
      DelCar = GameObject.Find("DriverCar");  
    }

    public void CarSelect(Sprite carSprite)
    {
      spriteRenderer = DelCar.GetComponent<SpriteRenderer>();  

      spriteRenderer.sprite = carSprite;
    }
}
