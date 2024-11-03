namespace text_adventure.dto
{
    public class GameState
    {
        public string CurrentRoom { get; set; } = "start";

        public List<string> Inventory { get;  set; } = [];

        public Dictionary<string, Room> Rooms { get; set; } = [];

        public GameState()
        {
        }
    }
}
