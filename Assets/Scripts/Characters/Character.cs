namespace Project_Astrologian
{
    // Abstract base class representing a character in the game.
    // Provides shared properties and behavior for character types.
    public abstract class Character
    {
        // Unique identifier for the character.
        public string Id { get; protected set; }
        public string Name { get; protected set; }

        // Constructor to initialize a character with an ID and name.
        protected Character(string id, string name)
        {
            Id = id;
            Name = name;
        }

        // Virtual method for character interaction. Can be overridden by subclasses.
        public virtual void Talk()
        {
            UnityEngine.Debug.Log(
                Name + " has nothing to say right now."
            );
        }
    }
}