using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;
using Naninovel;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update

    //public int levelNumber;
    [SerializeField] GameStateSystem gameStateSystem;

    public void ExitDetectiveScene(){
        //var variableManager = Engine.GetService<ICustomVariableManager>();
        //variableManager.TryGetVariableValue<int>("Level", out var gameLevel);
        //int gameLevel = variableManager.GetVariableValue("Level");

        string scriptToSend = GetNaniScript(gameStateSystem.gameLevel);
        var switchCommand = new SwitchToVNMode {ScriptName = scriptToSend};
	    switchCommand.ExecuteAsync().Forget();
    }

    public string GetNaniScript(int levelNumber){
        switch (levelNumber){
            case 1:
                return "TestScript2";
            case 2:
                return "TestScript3";
            default:
                return "EndTestScript";

        }
    }
}
