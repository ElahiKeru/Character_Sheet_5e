using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_5E_Character_Sheet
{
    public class Statistics
    {
        #region Fields
        private string strengthScore;
        private int strengthMod;
        private string dexterityScore;
        private int dexterityMod;
        private string constitutionScore;
        private int constitutionMod;
        private string intelligenceScore;
        private int intelligenceMod;
        private string wisdomScore;
        private int wisdomMod;
        private string charismaScore;
        private int charismaMod;
        #endregion

        #region Properties
        /// <summary>
        /// Returns integer: Strength Score
        /// </summary>
        public string StrengthScore
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
        public string DexterityScore
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
        public string ConstitutionScore
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
        public string IntelligenceScore
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
        public string WisdomScore
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
        public string CharismaScore
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

        #region Methods
        public void CalculateStrengthMod()
        {
            StrengthMod = (int.Parse(strengthScore) - 10) / 2;
        }

        public void CalculateDexterityMod()
        {
            DexterityMod = (int.Parse(dexterityScore) - 10) / 2;
        }

        public void CalculateConstitutionMod()
        {
            ConstitutionMod = (int.Parse(constitutionScore) - 10) / 2;
        }

        public void CalculateIntelligenceMod()
        {
            IntelligenceMod = (int.Parse(intelligenceScore) - 10) / 2;
        }

        public void CalculateWisdomMod()
        {
            WisdomMod = (int.Parse(wisdomScore) - 10) / 2;
        }

        public void CalculateCharismaMod()
        {
            CharismaMod = (int.Parse(charismaScore) - 10) / 2;
        }
        #endregion
    }
}