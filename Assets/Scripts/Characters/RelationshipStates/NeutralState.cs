namespace Project_Astrologian
{
    // Represents the default relationship state.
    // The character remains polite without displaying
    // particularly strong romantic or negative feelings.
    public class NeutralState : IMoodState
    {
        public string GetMoodDescription()
        {
            return "neutral";
        }

        public void ReactToPlayer()
        {
            UnityEngine.Debug.Log(
                "Asterion responds politely."
            );
        }
    }
}