using UnityEngine;

namespace Project_Astrologian
{
    // Singleton responsible for managing the overall game,
    // including game data and transitions between gameplay states.
    public class GameManager : MonoBehaviour
    {
        // Provides a globally accessible reference to the GameManager.
        public static GameManager Instance { get; private set; }

        // Stores the current playthrough's information.
        public GameState State { get; private set; } = new GameState();

        // Represents the state currently being executed.
        public IGameState CurrentState { get; private set; }

        // Initializes the GameManager and prevents duplicate instances.
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
            ChangeState(new MainMenuState());
        }

        // Changes the current gameplay state.
        // Exits the previous state before entering the new one.
        public void ChangeState(IGameState newState)
        {
            if (newState == null) return;

            CurrentState?.Exit(this);
            CurrentState = newState;
            CurrentState.Enter(this);
        }

        // Executes the behavior of the current gameplay state.
        public void Tick()
        {
            CurrentState?.Execute(this);
        }

        // Starts a new game with the specified player name and pronouns.
        public void StartNewGame(string playerName, string pronouns)
        {
            State = new GameState();
            State.PlayerName = string.IsNullOrWhiteSpace(playerName)
                ? "Witch"
                : playerName.Trim();

            State.Pronouns = pronouns;
            State.CurrentDay = 1;
            State.CurrentPhase = DayPhase.Night;
            State.Crystals = 30;
            State.Affection = 0;

            // Initialize player stats with default values
            State.Stats.SetStat("Luck", 5);
            State.Stats.SetStat("Divination", 5);
            State.Stats.SetStat("Charisma", 5);
            State.Stats.SetStat("Alchemy", 5);

            ChangeState(new DailyOverviewState());
        }


        // Advances the game to the next day.
        // Transitions to the cliffhanger after the seventh day.
        public void AdvanceDay()
        {
            if (State.CurrentDay >= 7)
            {
                ChangeState(new CliffhangerState());
                return;
            }

            State.CurrentDay++;
            State.CurrentPhase = DayPhase.Night;
            ChangeState(new DailyOverviewState());
        }
    }
}