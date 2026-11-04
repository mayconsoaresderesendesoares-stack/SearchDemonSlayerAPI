namespace SearchDemonSlayerAPI.Models
{
    public class CharacterResponse
    {
        public List<Character>? content { get; set; }
        public List<Character>? data { get; set; }
    }

    public class Character
    {
        public string? name { get; set; }
        public object? age { get; set; }
        public string? race { get; set; }
        public string? quote { get; set; }
        public string? img { get; set; }
    }
}