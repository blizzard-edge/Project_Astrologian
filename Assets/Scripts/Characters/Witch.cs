namespace Project_Astrologian
{
    // Represents the player-controlled witch.
    // Stores the player's chosen name, pronouns, and stats.
    public class Witch : Character
    {
        // The player's chosen pronouns (e.g., "she/her", "he/him", "they/them").
        public string Pronouns { get; private set; }

        // The player's current stats, including attributes like health, mana, and other relevant values.
        public PlayerStats Stats { get; private set; }


        // Initializes the player character with their selected information.
        public Witch(
            string name,
            string pronouns,
            PlayerStats stats
        ) : base("player", name)
        {
            Pronouns = pronouns;
            Stats = stats;
        }
    }
}