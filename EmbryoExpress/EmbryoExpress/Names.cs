using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmbryoExpress
{
    public static class Names
    {
        /// <summary>
        /// get the product name without trading mark
        /// </summary>
        public static string ProductNameWithoutTM
        {
            get
            {
                return Application.ProductName.TrimEnd(new char[] { '®', '™' });
            }
        }

        /// <summary>
        /// get NovoSampler name with trade mark
        /// </summary>
        public static string NovoSamplerWithTM
        {
            get
            {
                return NovoSampler + (BaseFunction.ChineseEdition ? "™" : "®");
            }
        }

        /// <summary>
        /// get NovoSampler Pro name with trade mark
        /// </summary>
        public static string NovoSamplerProWithTM
        {
            get
            {
                return NovoSamplerWithTM + " Pro";
            }
        }

        /// <summary>
        /// get NovoSampler 3 name with trade mark
        /// </summary>
        public static string NovoSampler3WithTM
        {
            get
            {
                return NovoSamplerWithTM + " Q";
            }
        }

        /// <summary>
        /// get NovoCyte name with trade mark
        /// </summary>
        public static string NovoCyteNameWithTM
        {
            get
            {
                return NovoCyteName + "®";
            }
        }

        /// <summary>
        /// get NovoCyte name with trade mark
        /// </summary>
        public static string NovoCyte2NameWithTM
        {
            get
            {
                return NovoCyteName + " Quanteon" + "™";
            }
        }

        /// <summary>
        /// get NovoCyte name with trade mark, 二代仪器国内名称为 Quanteon，国外为 NovoCyte Quanteon
        /// </summary>
        public static string NovoCyte2CnNameWithTM
        {
            get
            {
                return "Quanteon" + "™";
            }
        }

        public static readonly string NovoSampler = "NovoSampler";

        public static readonly string NovoSamplerPro = "NovoSampler Pro";

        public static readonly string NovoSampler3 = "NovoSampler Q";

        public static readonly string NovoCyteName = "NovoCyte";

        public static readonly string NovoCyte2Name = "NovoCyte Quanteon";

        public static readonly string NovoCyte2CnName = "Quanteon";//二代仪器国内名称为 Quanteon，国外为 NovoCyte Quanteon

        public static readonly string NovoCyte2NameOld = "NovoCyteII";
    }
}
