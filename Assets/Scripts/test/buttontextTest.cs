using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttontextTest : MonoBehaviour
{
    public Text textObject;
    GameObject obj1;
    bool isHint;
    //public int fontSize ;
    // Start is called before the first frame update
    void start()
    {
        textObject = GetComponent<Text>();
        isHint = false;
    }

    public void Changer()
    {
        isHint = !isHint;
        if (isHint == false)
        {
            textObject.text = "E키를 눌러 아이템을 먹어보세요";
        }
        else
        {
            textObject.text = "Hint";
        }
    }
}
