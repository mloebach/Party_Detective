using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx.Async;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitDetectiveScene(){
        var switchCommand = new SwitchToVNMode { ScriptName = "TestScript" };
	    switchCommand.ExecuteAsync().Forget();
    }
}
