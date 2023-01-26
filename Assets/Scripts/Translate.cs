using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class Translate : MonoBehaviour
{
    public Vector3 startPosition;

    public void Transform ()
    {
        transform.position = startPosition;
    }

}