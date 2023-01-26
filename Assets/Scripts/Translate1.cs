using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class Translate1 : MonoBehaviour
{
    public Vector3 startPosition;

    public void Transform ()
    {
        transform.position = startPosition;
    }

}