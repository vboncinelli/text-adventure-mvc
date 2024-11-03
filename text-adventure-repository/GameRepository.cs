using System.Reflection;
using System.Text.Json;
using text_adventure.dto;

namespace text_adventure_repository
{
    public class GameRepository : IGameRepository
    {
        public GameState GetGameState()
        {
            var fileName = "gameState.json";

            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, fileName);

            if (!File.Exists(filePath))
            {
                throw new Exception($"unable to find {fileName}");
            }

            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<GameState>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }) ?? throw new Exception("unable to load the state of the game");
        }
    }
}
