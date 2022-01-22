using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OnClickEvents : MonoBehaviour
{
    public TextMeshProUGUI nameField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubmitScore()
    {
        HighScores.UploadScore(nameField.text, PlayerPrefs.GetInt("Highscore",0));
    }
}
