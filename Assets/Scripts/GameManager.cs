using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    
    public GameObject player;

    public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    public Text pickupText;

    void Update(){
        LevelCompleteCheck();
        UpdateGUI();
    }

    private void LevelCompleteCheck(){

        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
        }


    private void UpdateGUI(){
        pickupText.text = "Vulnerabilites Found: " + currentPickups + "/" + maxPickups;
    }
}
