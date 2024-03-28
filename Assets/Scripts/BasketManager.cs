using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour
{
    public GameObject basket;
    public float value;
    public Vector3 sizeChange;

    public void RotateLeft()
    {
       basket.transform.Rotate(0f, 0f, 20f);
    }

    public void RotateRight()
    {
       basket.transform.Rotate(0f, 20f, 0f); 
    }

    public void Grow()
    {
       basket.transform.localScale = basket.transform.localScale + sizeChange;
    }
}
    