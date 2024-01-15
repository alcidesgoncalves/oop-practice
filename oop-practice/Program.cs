class TestClass
{
    static void Main(string[] args)
    {
        List<Pokemon> PokemonList = new List<Pokemon>(); 
        PokemonList.Add(new Pokemon("Bulbasaur", "Grass/Poison", new Dictionary<string, string> { 
            {"Tackle", "Normal"}, 
            {"Vine-Whip", "Grass"},
            {"Growth", "Normal"},
            { "Razor Leaf", "Grass"} 
            }));
        PokemonList.Add(new Pokemon("Charmander", "Fire", new Dictionary<string, string> { 
            {"Scratch", "Normal"}, 
            {"Growth", "Normal"}, 
            {"Ember", "Fire" }, 
            {"Slash", "Normal"} 
        }));
        PokemonList.Add(new Pokemon("Squirtle", "Water", new Dictionary<string, string> 
        { 
            {"Tackle", "Normal"}, 
            {"Water-Gun", "Water"}, 
            {"Growth", "Normal"}, 
            {"Bubbles", "Water"} 
        }));
        foreach (var Pokemon in PokemonList)
        {
            Console.WriteLine($"Pokemon: {Pokemon.Name}, Type: {Pokemon.Type}, Moveset: {Pokemon.GetMovesetAsString()}");
        }
        
    }
}

public class Pokemon
{
    public string Name { get; set;}
    public string Type { get; set;} 
    public Dictionary<string, string> Moveset { get; set;}

    public Pokemon()
    {
        // Inicialização padrão
        Name = "???";
        Type = "N/A";
        Moveset = new Dictionary<string, string>();
    }

    public Pokemon(string name, string type, Dictionary<string, string> moveset){
        Name = name;
        Type = type;
        Moveset = moveset;
    }
     public string GetMovesetAsString()
    {
        return string.Join(", ", Moveset.Select(move => $"{move.Key} ({move.Value})"));
    }
}