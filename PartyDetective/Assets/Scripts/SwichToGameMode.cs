using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;
using UniRx.Async;

[CommandAlias("detective")]
public class SwitchToAdventureMode : Command
{
    public override async UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        // 1. Disable Naninovel input.
        var inputManager = Engine.GetService<IInputManager>();
        inputManager.ProcessInput = false;

        // 2. Stop script player.
        var scriptPlayer = Engine.GetService<IScriptPlayer>();
        scriptPlayer.Stop();

        // 3. Reset state.
        var stateManager = Engine.GetService<IStateManager>();
        await stateManager.ResetStateAsync();

        // 4. Switch cameras.
        var advCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        advCamera.enabled = true;
        var naniCamera = Engine.GetService<ICameraManager>().Camera;
        naniCamera.enabled = false;

        // 5. Enable character control.
        //var controller = Object.FindObjectOfType<CharacterController3D>();
        //controller.IsInputBlocked = false;
        //var detectiveScene =  GameObject.Find("DetectiveSceneObject");
        var detectiveScene = GameObject.Find("DetectiveSceneObject").transform.GetChild(0).gameObject;
        detectiveScene.SetActive(true);
        //detectiveScene.enabled = true;
    }
}