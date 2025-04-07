using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoverWorder : MonoBehaviour
{
    public TMP_Text wordText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Slide the text down
        wordText.rectTransform.Translate(Vector3.down * 50 * Time.deltaTime);

        // Check if the text has reached the bottom (game over condition)
        if (wordText.rectTransform.position.y < -Screen.height / 2)
        {
            Debug.Log("Game Over!");
            // Reset the game or show a game-over screen
        }
        
    }
}
