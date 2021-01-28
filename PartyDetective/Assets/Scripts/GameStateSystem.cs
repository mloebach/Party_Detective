using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {VisualNovel, Detective}
public class GameStateSystem : MonoBehaviour
{

    //[SerializeField] VNController vNController;
    [SerializeField] DetectiveScene detectiveController;
    [SerializeField] Camera worldCamera;
    GameState state;
    private void Start()
    {
        
    }

    void JumpToVN(){
        state = GameState.VisualNovel;
        detectiveController.gameObject.SetActive(false);
    }
    void JumpToDetective(){
        state = GameState.Detective;
        detectiveController.gameObject.SetActive(true);
    }
}
