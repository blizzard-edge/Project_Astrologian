/*
* Author: Caitlin Hagler
* Class: CFriendlyState
* IDE: VSCode
* Last Revision Date: November 2, 2026
*/

namespace Project_Astrologian
{
    /* 
    * Represents a friendly relationship between
    * the player and the love interest.\
    */
    public class FriendlyState : IMoodState
    {
        public string GetMoodDescription()
        {
            return "friendly";
        }

        public void ReactToPlayer()
        {
            UnityEngine.Debug.Log(
                $"{Name} responds warmly."
            );
        }
    }
}
