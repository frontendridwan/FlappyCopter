using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject rocks;
    int score = -2;
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
            GUILayout.Label("Score : " + score.ToString());
        }

    }
}
