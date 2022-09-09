using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour
{
    public InputField passwordInput;
    
    void LockInput(InputField input)
    {
        if(input.text.Length == 0)
        {
            Debug.Log("Main Input Empty");
        }
        else if(input.text == "1234")
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong");
        }
    }

    public void Start()
    {
        passwordInput.onSubmit.AddListener(delegate{LockInput(passwordInput);});
    }
}
