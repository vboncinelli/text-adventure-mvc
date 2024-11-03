namespace text_adventure.dto;

public class Room
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public Dictionary<string, string> Commands { get; set; } = [];

    public List<RoomAction> RoomActions { get; set; } = [];

    public List<string> Items { get; set; } = [];
}