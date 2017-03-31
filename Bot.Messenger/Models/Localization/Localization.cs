using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "locales")]
    public partial class Localization
    {

        private List<Locale> localesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("locale")]
        public List<Locale> Locales
        {
            get
            {
                return this.localesField;
            }
            set
            {
                this.localesField = value;
            }
        }
    }
}
