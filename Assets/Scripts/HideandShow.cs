using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideandShow : MonoBehaviour
{
    // Start is called before the first frame update
    public void showIt(GameObject obj) {
        obj.SetActive(true);
    }
    
    public void hideIt(GameObject obj) {
        obj.SetActive(false);
    }
}
