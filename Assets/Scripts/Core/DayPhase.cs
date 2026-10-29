namespace Project_Astrologian
{
    // Defines the different stages of a gameplay day.
    // Used to track the player's progression through the daily cycle.

    public enum DayPhase
    {
        // Moon phase and tarot draw.
        Night,

        // Ingredient shopping and potion preparation.
        Morning,

        // First interaction period with Asterion.
        Midday,

        // Second interaction period with Asterion.
        Evening,

        // Displays a summary of the day's events.
        DaySummary,

        // Allows the player to brew potions and prepare for the next day.
        WitchingHour,

        // Indicates that the current story has reached its conclusion.
        Finished
    }
}