namespace Project_Astrologian
{
    // Represents a negative relationship state.
    // The character becomes distant or cautious toward the player.
    public class HostileState : IMoodState
    {
        public string GetMoodDescription()
        {
            return "distant";
        }

        public void ReactToPlayer()
        {
            UnityEngine.Debug.Log(
                $"{Name} responds cautiously."
            );
        }
    }
}