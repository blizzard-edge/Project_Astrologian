namespace Project_Astrologian
{
    // Defines the interface for the relationship State pattern.
    // Each concrete state provides its own character reactions
    // and relationship descriptions.
    public interface IMoodState
    {
        // Returns a string description of the character's current mood.
        string GetMoodDescription();

        // Defines how the character reacts to the player based on their current mood.
        void ReactToPlayer();
    }
}