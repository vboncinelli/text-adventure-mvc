using text_adventure.dto;

namespace text_adventure.mvc.Services
{
    public interface IGameService
    {
        GameState LoadGameState();

        string ProcessPlayerCommand(string command, GameState gameState);

        void SaveGameState(GameState gameState);
    }
}
