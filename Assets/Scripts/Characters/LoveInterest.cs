using System.Collections.Generic;

namespace Project_Astrologian
{
    // Represents a romantic or relationship character.
    // Stores affection points, gift preferences, and relationship state.
    public class LoveInterest : Character
    {
        // The current affection points the player has with this character.
        public int AffectionPoints { get; private set; }

        // A list of item IDs that this character prefers as gifts.
        public List<string> FavoriteItemIds { get; private set; }
            = new List<string>();

        // The current relationship state of the character, which can be Neutral, Friendly, or Hostile.
        public IModState RelationshipState { get; private set; }

        // Initializes a love interest character with an ID and name.
        public LoveInterest(string id, string name)
            : base(id, name)
        {
            RelationshipState = new NeutralState();
        }

        // Processes a gift received from the player.
        // Gift potions increase affection according to their effect value.
        public void ReceiveGift(Item item)
        {
            if (item is Potion potion && potion.IsGiftPotion)
            {
                AddAffection(potion.AffectionValue);
            }
        }

        // Adds affection points to the character and updates the relationship state accordingly.
        public void AddAffection(int amount)
        {
            AffectionPoints =
                System.Math.Max(0, AffectionPoints + amount);

            UpdateRelationshipState();
        }

        // Updates the relationship state based on the current affection points.
        private void UpdateRelationshipState()
        {
            if (AffectionPoints >= 20)
                RelationshipState = new FriendlyState();

            else if (AffectionPoints <= -10)
                RelationshipState = new HostileState();

            else
                RelationshipState = new NeutralState();
        }
    }
}