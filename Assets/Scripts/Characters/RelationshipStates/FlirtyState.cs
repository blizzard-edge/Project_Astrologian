namespace Project_Astrologian
{
    // Represents a flirtatious relationship state.
    // The character displays more playful or romantic behavior.
    public class FlirtyState : IMoodState
    {
        public string GetMoodDescription()
        {
            return "playfully flirtatious";
        }

        public void ReactToPlayer()
        {
            UnityEngine.Debug.Log(
                $"{Name} responds with quiet amusement."
            );
        }
    }
}