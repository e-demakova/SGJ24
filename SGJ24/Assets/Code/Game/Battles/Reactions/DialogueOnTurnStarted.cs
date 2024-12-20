using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Game.Battles.Triggers;
using Game.Dialogues;
using Game.Infrastructure.Data;
using Utils.Localization;
using Zenject;

namespace Game.Battles.Reactions
{
  public class DialogueOnTurnStarted : IReaction
  {
    private readonly List<LocalizedString> _replicas;
    private IGameData _data;
    private int _availableExecutions = 1;
    private MainCamera MainCamera => _data.Get<SceneData>().Get<MainCamera>();

    public DialogueOnTurnStarted(List<LocalizedString> replicas)
    {
      _replicas = replicas;
    }

    [Inject]
    private void Construct(IGameData data)
    {
      _data = data;
    }

    public bool CanReact(ITrigger trigger, CombatantData owner) =>
      _availableExecutions > 0 && trigger is BattleStartedTrigger;

    public async UniTask React(ITrigger trigger, CombatantData owner)
    {
      _availableExecutions--;

      await MainCamera.ZoomIn();
      await _data.Get<SceneData>().Get<DialogueUI>().ShowDialogue(_replicas);
      await MainCamera.ZoomOut();
    }
  }
}