using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Locale
    {

        private string englishNameField;

        private List<LocaleCode> codesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("englishName")]
        public string EnglishName
        {
            get
            {
                return this.englishNameField;
            }
            set
            {
                this.englishNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("codes")]
        [System.Xml.Serialization.XmlArrayItemAttribute("code")]
        public List<LocaleCode> Codes
        {
            get
            {
                return this.codesField;
            }
            set
            {
                this.codesField = value;
            }
        }
    }
}
