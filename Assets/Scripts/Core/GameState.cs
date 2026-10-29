using System;
using System.Collections.Generic;

namespace Project_Astrologian
{
    // Stores the current playthrough's data, including player information,
    // progression, resources, stats, inventory, and story progress.
    [Serializable]
    public class GameState
    {
        // Player's chosen name and pronouns.
        public string PlayerName = "Witch";
        public string Pronouns = "she/her";

        // Current day and phase of the game.
        public int CurrentDay = 1;
        public DayPhase CurrentPhase = DayPhase.Night;


        // Player resources and relationship progress.
        public int Crystals = 30;
        public int Affection = 0;

        // Stores the player's current stat values.
        public PlayerStats Stats = new PlayerStats();

        // Stores the ingredients and items currently owned by the player.
        public List<InventoryEntry> Inventory =
            new List<InventoryEntry>();

        // Stores the story flags that track the player's progress and choices.
        public List<string> StoryFlags =
            new List<string>();

        // Stores the current dialogue ID for the ongoing conversation.
        public string CurrentDialogueId = "day1_start";
    }

    public enum DayPhase
    {
        Night,
        Morning,
        Midday,
        Evening,
        DaySummary,
        WitchingHour,
        Finished
    }

    [Serializable]
    public class InventoryEntry
    {
        public string ItemId;
        public int Quantity;

        public InventoryEntry(string itemId, int quantity)
        {
            ItemId = itemId;
            Quantity = quantity;
        }
    }
}