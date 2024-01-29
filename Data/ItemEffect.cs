using System;

namespace Data
{
  enum ItemEffectType
  {
    Active,
    Passive
  }
  class ItemEffect(string name, string discription, ItemEffectType type, bool isUnique)
  {
    public string Name { get; set; } = name;
    public ItemEffectType EffectType { get; set; } = type;
    public string Discription { get; set; } = discription;
    public bool IsUnique { get; set; } = isUnique;
  }
}