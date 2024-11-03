namespace text_adventure.dto
{
    public class RoomAction
    {
        public required string Action { get; set; }

        public string? Require { get; set; }

        public Dictionary<string, string> Commands { get; set; } = [];

        public required string Message { get; set; }
    }
}
