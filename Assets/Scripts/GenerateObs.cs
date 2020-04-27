using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject rocks;
    int score = -2;
    GUIStyle guiStyle = new GUIStyle();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 1.5f);
    }

    void CreateObstacle()
    {
        Instantiate (rocks);
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if(score >= 0){
            GUI.color = Color.black;
            guiStyle.fontSize = 40;
            GUI.Label(new Rect(0, 0, 300, 50),  "Score : " + score.ToString(), guiStyle);
        }

    }
}
