﻿using System.Collections.Generic;
using Game.Infrastructure.AssetsManagement;
using Game.Shop;

namespace Game.Cards
{
  public static class CardsList
  {
    public static List<CardData> Common => new()
    {
      Eye,
      Finger,
      Cake
    };
    
    public static List<CardData> Trash => new()
    {
      EyeTrash,
      FingerTrash,
      CakeTrash
    };
    
    public static List<CardData> Rare => new()
    {
      EyeRare,
      FingerRare,
      CakeRare
    };
    
    public static List<CardData> Immortal => new()
    {
      EyeRare,
      FingerRare,
      CakeRare
    };

    public static CardData EyeTrash => new()
    {
      BuyCost = 0,
      SellCost = 0,
      SpritePath = Assets.CardEye,
      Spell = new DecreaseEnemyAtkSpell(0)
    };

    public static CardData Eye => new()
    {
      BuyCost = 2,
      SellCost = 1,
      SpritePath = Assets.CardEye,
      Spell = new DecreaseEnemyAtkSpell(1)
    };

    public static CardData EyeRare => new()
    {
      BuyCost = 4,
      SellCost = 2,
      SpritePath = Assets.CardEye,
      Spell = new DecreaseEnemyAtkSpell(4)
    };

    public static CardData Finger => new()
    {
      BuyCost = 2,
      SellCost = 1,
      SpritePath = Assets.CardFinger,
      Spell = new IncreaseAtkSpell(1)
    };

    public static CardData FingerTrash => new()
    {
      BuyCost = 0,
      SellCost = 0,
      SpritePath = Assets.CardFinger,
      Spell = new IncreaseAtkSpell(0)
    };

    public static CardData FingerRare => new()
    {
      BuyCost = 4,
      SellCost = 2,
      SpritePath = Assets.CardFinger,
      Spell = new IncreaseAtkSpell(4)
    };

    public static CardData Cake => new()
    {
      BuyCost = 2,
      SellCost = 1,
      SpritePath = Assets.CardCake,
      Spell = new IncreaseHpSpell(2)
    };
    
    public static CardData CakeTrash => new()
    {
      BuyCost = 0,
      SellCost = 0,
      SpritePath = Assets.CardCake,
      Spell = new IncreaseHpSpell(0)
    };
    
    public static CardData CakeRare => new()
    {
      BuyCost = 4,
      SellCost = 2,
      SpritePath = Assets.CardCake,
      Spell = new IncreaseHpSpell(4)
    };
  }
}