using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;
using UniRx.Async;


[CommandAlias("novel")]
public class SwitchToVNMode : Command
{
    public StringParameter ScriptName;
    public StringParameter Label;

    //[SerializeField] Camera worldCamera;

    public override async UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        // 1. Disable character control.
        /*var controller = Object.FindObjectOfType<CharacterController3D>();
        controller.IsInputBlocked = true;*/
        var detectiveScene = GameObject.Find("DetectiveSceneObject").transform.GetChild(0).gameObject;
        detectiveScene.SetActive(false);

        // 2. Switch cameras.
        var advCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        advCamera.enabled = false;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = true;

        // 3. Load and play specified script (if assigned).
        if (Assigned(ScriptName))
        {
            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            await scriptPlayer.PreloadAndPlayAsync(ScriptName, label: Label);
        }

        //var stateManager = Engine.GetService<IStateManager>();
        //await stateManager.LoadGameAsync("varStorage");

        // 4. Enable Naninovel input.
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = true;


    }
}