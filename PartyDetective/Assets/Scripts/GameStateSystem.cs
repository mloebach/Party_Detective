using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum GameState {VisualNovel, Detective}
public class GameStateSystem : MonoBehaviour
{

    //[SerializeField] VNController vNController;
    [SerializeField] DetectiveScene detectiveController;
    [SerializeField] Camera worldCamera;
    GameState state;

    public TMP_Text levelText;

    //public var variableManagerStorage;

    public int gameLevel;
    private void Start()
    {
        
    }

    /*void JumpToVN(){
        state = GameState.VisualNovel;
        detectiveController.gameObject.SetActive(false);
    }
    void JumpToDetective(){
        state = GameState.Detective;
        gameLevel++;
        levelText.text = "Level " + gameLevel.ToString();
        detectiveController.gameObject.SetActive(true);
    }*/
}
