class TestClass
{
    static void Main(string[] args)
    {
        List<Pokemon> PokemonList = new List<Pokemon>(); 
        PokemonList.Add(new Pokemon("Bulbasaur", "Grass/Poison", new List<string> { "Tackle", "Vine-Whip", "Growth", "Razor Leaf" }));
        PokemonList.Add(new Pokemon("Charmander", "Fire", new List<string> { "Scratch", "Growth", "Ember", "Slash" }));
        PokemonList.Add(new Pokemon("Squirtle", "Water", new List<string> { "Tackle", "Water-Gun", "Growth", "Bite" }));
        foreach (var Pokemon in PokemonList)
        {
            Console.WriteLine($"Pokemon: {Pokemon.Name}, Type: {Pokemon.Type}, Moveset: {string.Join(", ", Pokemon.Moveset)}");
        }
        
    }
}

public class Pokemon
{
    public string Name { get; set;}
    public string Type { get; set;} 
    public List<string> Moveset { get; set;}

    public Pokemon()
    {
        // Inicialização padrão
        Name = "???";
        Type = "N/A";
        Moveset = new List<string>();
    }

    public Pokemon(string name, string type, List<string> moveset){
        Name = name;
        Type = type;
        Moveset = moveset;
    }

    public override string ToString()
    {
        return $"{Name} - Type: {Type} - Moveset: {string.Join(", ", Moveset)}";
    }
}