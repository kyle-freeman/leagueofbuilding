namespace Data
{
  class SpellContainer(string name, string discription, string spellButton)
  {
    public string Name { get; set; } = name;
    public string SpellButton { get; set; } = spellButton;
    public string Discription { get; set; } = discription;
  }
}