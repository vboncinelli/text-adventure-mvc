using text_adventure.dto;

namespace text_adventure_repository
{
    public interface IGameRepository
    {
        GameState GetGameState();
    }
}
