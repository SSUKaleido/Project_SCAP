using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    
    bool isHint;
    //public int fontSize ;
    // Start is called before the first frame update
    void Start()
    {
        isHint = false;
        gameObject.active = isHint;
    }

    public void Changer()
    {
        isHint = !isHint;
        gameObject.active = isHint;
    }
}
