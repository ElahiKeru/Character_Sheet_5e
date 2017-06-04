using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace DND_5E_Character_Sheet
{
    public class Statistics
    {
        #region Fields
        private int strengthScore;
        private int strengthMod;
        private int dexterityScore;
        private int dexterityMod;
        private int constitutionScore;
        private int constitutionMod;
        private int intelligenceScore;
        private int intelligenceMod;
        private int wisdomScore;
        private int wisdomMod;
        private int charismaScore;
        private int charismaMod;
        #endregion

        #region Properties
        /// <summary>
        /// Returns integer: Strength Score
        /// </summary>
        public int StrengthScore
        {
            get
            {
                return strengthScore;
            }

            set
            {
                strengthScore = value;
            }
        }

        /// <summary>
        /// Returns integer: Strength Modifier
        /// </summary>
        public int StrengthMod
        {
            get
            {
                return strengthMod;
            }

            set
            {
                strengthMod = value;
            }
        }

        /// <summary>
        /// Returns integer: Dexterity Score
        /// </summary>
        public int DexterityScore
        {
            get
            {
                return dexterityScore;
            }

            set
            {
                dexterityScore = value;
            }
        }

        /// <summary>
        /// Returns integer: Dexterity Modifier
        /// </summary>
        public int DexterityMod
        {
            get
            {
                return dexterityMod;
            }

            set
            {
                dexterityMod = value;
            }
        }

        /// <summary>
        /// Returns integer: Constitution Score
        /// </summary>
        public int ConstitutionScore
        {
            get
            {
                return constitutionScore;
            }

            set
            {
                constitutionScore = value;
            }
        }

        /// <summary>
        /// Returns integer: Constitution Modifier
        /// </summary>
        public int ConstitutionMod
        {
            get
            {
                return constitutionMod;
            }

            set
            {
                constitutionMod = value;
            }
        }

        /// <summary>
        /// Returns integer: Intelligence Score
        /// </summary>
        public int IntelligenceScore
        {
            get
            {
                return intelligenceScore;
            }

            set
            {
                intelligenceScore = value;
            }
        }

        /// <summary>
        /// Returns integer: Intelligence Modifier
        /// </summary>
        public int IntelligenceMod
        {
            get
            {
                return intelligenceMod;
            }

            set
            {
                intelligenceMod = value;
            }
        }

        /// <summary>
        /// Returns integer: Wisdom Score
        /// </summary>
        public int WisdomScore
        {
            get
            {
                return wisdomScore;
            }

            set
            {
                wisdomScore = value;
            }
        }

        /// <summary>
        /// Returns integer: Wisdom Modifier
        /// </summary>
        public int WisdomMod
        {
            get
            {
                return wisdomMod;
            }

            set
            {
                wisdomMod = value;
            }
        }

        /// <summary>
        /// Returns integer: Charisma Score
        /// </summary>
        public int CharismaScore
        {
            get
            {
                return charismaScore;
            }

            set
            {
                charismaScore = value;
            }
        }

        /// <summary>
        /// Returns integer: Charisma Modifier
        /// </summary>
        public int CharismaMod
        {
            get
            {
                return charismaMod;
            }

            set
            {
                charismaMod = value;
            }
        }
        #endregion
    }
}