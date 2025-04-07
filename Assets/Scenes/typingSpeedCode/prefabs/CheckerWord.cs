using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CheckerWord : MonoBehaviour
{
    void OnEnable()
    {
        typingInputWords.OnCheckWord += Checking;
    }

    void OnDisable()
    {
        typingInputWords.OnCheckWord -= Checking;
    }

    void Checking(string res)
    {
        // get reference text mesh pro (must step)
        string txt = this.GetComponent<TextMeshProUGUI>().text;
        if(txt == res)
        {
            if(this.gameObject.tag == "0")
            {
                WordsSpawnManager.wordGoodused.Remove(Convert.ToInt32(this.gameObject.name));
            }
             if(this.gameObject.tag == "1")
            {
                WordsSpawnManager.wordBaddused.Remove(Convert.ToInt32(this.gameObject.name));
            }
            Destroy(this.gameObject);
        }
    }
}
