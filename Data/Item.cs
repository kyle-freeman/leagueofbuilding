using System;

namespace Data
{
  class Item
  {
    public string Name { get; set; } = "N/A";
    public string Description { get; set; } = "N/A";

    public Dictionary<StatType, int> StatBonuses { get; set; } = [];
  }
}