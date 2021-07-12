using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static GameManager instance;
    public static int gameScore_right;
    public static int gameScore_wrong;
    public Text right_text;
    public Text wrong_text;
    int temp_cube = 0;
    int temp_sphere = 0;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void Getscore(int value, int t) 
    {

        if (t == 1) // 1 is right
        {
            gameScore_right += value;
        }
        else if (t == 2) // 2 is wrong
        {
            gameScore_wrong += value;
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.F) )
        {
            gameScore_right = 0;
            gameScore_wrong = 0;
        }
        right_text.text = gameScore_right.ToString();
        wrong_text.text = gameScore_wrong.ToString();
        
    }
}


