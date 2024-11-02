﻿using Cysharp.Threading.Tasks;
using Game.Infrastructure.Data;
using Zenject;

namespace Game.Battles
{
  public interface IReaction
  {
    bool CanReact(ITrigger trigger, CombatantData owner);
    UniTask React(ITrigger trigger, CombatantData owner);
  }

  public class SummonOnDeathReaction : IReaction
  {
    private int _availableExecutions = 1;

    private IGameData _data;
    private ArenaData ArenaData => _data.Get<ArenaData>();

    [Inject]
    private void Construct(IGameData data) =>
      _data = data;

    public bool CanReact(ITrigger trigger, CombatantData owner) =>
      _availableExecutions > 0 && trigger is DeathTrigger death && death.Corpse == owner;

    public async UniTask React(ITrigger trigger, CombatantData owner)
    {
      _availableExecutions--;
      ArenaData.SupportArrived = true;
    }
  }
}