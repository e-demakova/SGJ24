﻿using Game.Dialogues;
using Game.Infrastructure.Data;
using Utils.Localization;

namespace Game.Shop
{
  public class CardData : IData
  {
    public int BuyCost;
    public int SellCost;
    
    public string SpritePath;
    public LocalizedString Description = DescriptionsList.Default;
  }
}