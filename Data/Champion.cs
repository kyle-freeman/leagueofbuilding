namespace Data
{
  class Champion
  {
    public string Name { get; set; } = "";
    public Dictionary<StatType, float> Stats = [];
    public List<List<SpellContainer>> SpellSets { get; set; } = [];
    public int Level { get; set; }
    public Champion()
    {
      Enum.GetValues<StatType>().ToList().ForEach(stat => Stats.Add(stat, 0));

    }
  }
}