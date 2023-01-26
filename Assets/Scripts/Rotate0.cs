using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate0 : MonoBehaviour
{
    private bool rotating = true;
    public void Update()
    {
        if (rotating)
        {
            Vector3 to = new Vector3(0, 0, 0);
            if (Vector3.Distance(transform.eulerAngles, to) > 0.01f)
            {
                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
            }
            else
            {
                transform.eulerAngles = to;
                rotating = false;
            }
        }
        
    }
}
