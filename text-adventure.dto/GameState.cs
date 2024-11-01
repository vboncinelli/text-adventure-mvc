namespace text_adventure.dto
{
    public class GameState
    {
        public string CurrentRoom { get; set; } = "start";

        public List<string> Inventory { get;  set; } = [];

        public Dictionary<string, Room> Rooms { get; init; }
        
        public GameState(Dictionary<string, Room> rooms)
        {
            Rooms = rooms;
        }
    }
}
