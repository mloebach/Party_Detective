using Naninovel;
using Naninovel.Commands;
using UniRx.Async;
using UnityEngine;

[CommandAlias("testCommand")]
public class TestCommand : Command
{
    public StringParameter Message;

    public override UniTask ExecuteAsync (CancellationToken cancellationToken = default)
    {
        if (Assigned(Message))
        {
            Debug.Log($"Hello, {Message}.");
        }
        else
        {
            Debug.Log("Hello World!");
        }

        return UniTask.CompletedTask;
    }
}