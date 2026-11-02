/*
* Author: Caitlin Hagler
* Class: NeutralState
* IDE: VSCode
* Last Revision Date: November 2, 2026
*/

namespace Project_Astrologian
{
    /*
    * Represents the default relationship state.
    * The character remains polite without displaying
    * particularly strong romantic or negative feelings.
    */
    public class NeutralState : IMoodState
    {
        public string GetMoodDescription()
        {
            return "neutral";
        }

        public void ReactToPlayer()
        {
            UnityEngine.Debug.Log(
                $"{Name} responds politely."
            );
        }
    }
}
