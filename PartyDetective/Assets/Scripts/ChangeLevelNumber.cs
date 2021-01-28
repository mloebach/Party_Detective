using Naninovel;
using Naninovel.Commands;
using UniRx.Async;
using UnityEngine;

[CommandAlias("levelEquals")]
public class ChangeLevelNumber : Command
{
    public StringParameter Name;
    public IntegerParameter Level;

    public override UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        if (Assigned(Level))
        {
            Debug.Log("Level Change to:" + Level);
            var internalGameLevel = GameObject.Find("GameStateSystem").GetComponent<GameStateSystem>();
            Debug.Log("Old Level:" + internalGameLevel.gameLevel);
            internalGameLevel.gameLevel = Level;
            internalGameLevel.levelText.text = "Level " + Level;
        }
        else
        {
            Debug.Log("level please");
        }

        return UniTask.CompletedTask;
    }
}