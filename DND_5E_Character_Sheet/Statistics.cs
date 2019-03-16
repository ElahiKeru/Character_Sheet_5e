using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DND_5E_Character_Sheet
{
    public class Statistics
    {

        #region Properties
        /// <summary>
        /// Returns integer: Strength Score
        /// </summary>
        public string StrengthScore { get; set; }

        /// <summary>
        /// Returns integer: Strength Modifier
        /// </summary>
        public int StrengthMod { get; set; }

        /// <summary>
        /// Returns integer: Dexterity Score
        /// </summary>
        public string DexterityScore { get; set; }

        /// <summary>
        /// Returns integer: Dexterity Modifier
        /// </summary>
        public int DexterityMod { get; set; }

        /// <summary>
        /// Returns integer: Constitution Score
        /// </summary>
        public string ConstitutionScore { get; set; }

        /// <summary>
        /// Returns integer: Constitution Modifier
        /// </summary>
        public int ConstitutionMod { get; set; }

        /// <summary>
        /// Returns integer: Intelligence Score
        /// </summary>
        public string IntelligenceScore { get; set; }

        /// <summary>
        /// Returns integer: Intelligence Modifier
        /// </summary>
        public int IntelligenceMod { get; set; }

        /// <summary>
        /// Returns integer: Wisdom Score
        /// </summary>
        public string WisdomScore { get; set; }

        /// <summary>
        /// Returns integer: Wisdom Modifier
        /// </summary>
        public int WisdomMod { get; set; }

        /// <summary>
        /// Returns integer: Charisma Score
        /// </summary>
        public string CharismaScore { get; set; }

        /// <summary>
        /// Returns integer: Charisma Modifier
        /// </summary>
        public int CharismaMod { get; set; }
        #endregion

        #region Methods
        public void CalculateStrengthMod()
        {
            StrengthMod = (int.Parse(StrengthScore) - 10) / 2;
        }

        public void CalculateDexterityMod()
        {
            DexterityMod = (int.Parse(DexterityScore) - 10) / 2;
        }

        public void CalculateConstitutionMod()
        {
            ConstitutionMod = (int.Parse(ConstitutionScore) - 10) / 2;
        }

        public void CalculateIntelligenceMod()
        {
            IntelligenceMod = (int.Parse(IntelligenceScore) - 10) / 2;
        }

        public void CalculateWisdomMod()
        {
            WisdomMod = (int.Parse(WisdomScore) - 10) / 2;
        }

        public void CalculateCharismaMod()
        {
            CharismaMod = (int.Parse(CharismaScore) - 10) / 2;
        }
        #endregion
    }
}