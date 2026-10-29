namespace Project_Astrologian
{
    // Defines the common interface for all gameplay states.
    // Implemented by individual states to control their entry,
    // execution, and exit behavior.
    public interface IGameState
    {
        void Enter(GameManager manager);
        void Execute(GameManager manager);
        void Exit(GameManager manager);
    }
}