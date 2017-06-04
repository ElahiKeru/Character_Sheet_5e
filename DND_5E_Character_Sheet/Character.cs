using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_5E_Character_Sheet
{
    public class Character
    {
        #region Fields
        private List<string> characterAbilities;
        private List<string> characterInventory;
        private int characterLevel;
        private int characterProficiency;
        private int characterSaves;
        private int characterSkills;
        private Statistics characterStatistics;
        private int characterVocationList;
        private string characterName;
        private string characterPlayer;
        private string characterEthics;
        private string characterMorals;
        #endregion

        #region Properties
        public int CharacterSkills
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int CharacterSaves
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<string> CharacterInventory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<string> CharacterAbilities
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Returns integer: Character's Proficiency Bonus
        /// </summary>
        public int CharacterProficiency
        {
            get
            {
                return characterProficiency;
            }

            set
            {
                characterProficiency = value;
            }
        }

        /// <summary>
        /// Returns integer: Character's Total Level
        /// </summary>
        public int CharacterLevel
        {
            get
            {
                return characterLevel;
            }

            set
            {
                characterLevel = value;
            }
        }

        public int CharacterVocationList
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// Returns string: Character's Name
        /// </summary>
        public string CharacterName
        {
            get
            {
                return characterName;
            }

            set
            {
                characterName = value;
            }
        }

        /// <summary>
        /// Returns string: Character's Player's Name
        /// </summary>
        public string CharacterPlayer
        {
            get
            {
                return characterPlayer;
            }

            set
            {
                characterPlayer = value;
            }
        }

        /// <summary>
        /// Returns string: Character's inclination towards Law or Chaos
        /// </summary>
        public string CharacterEthics
        {
            get
            {
                return characterEthics;
            }

            set
            {
                characterEthics = value;
            }
        }

        /// <summary>
        /// Returns string: Character's inclination towards Good or Evil
        /// </summary>
        public string CharacterMorals
        {
            get
            {
                return characterMorals;
            }

            set
            {
                characterMorals = value;
            }
        }

        /// <summary>
        /// Returns lazy-loaded reference to Statistics object
        /// </summary>
        public Statistics CharacterStatistics
        {
            get
            {
                if(characterStatistics == null)
                {
                    characterStatistics = new Statistics();
                }

                return characterStatistics;
            }

            set
            {
                characterStatistics = value;
            }
        }
        #endregion
    }
}