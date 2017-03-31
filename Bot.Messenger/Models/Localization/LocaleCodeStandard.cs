using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class LocaleCodeStandard
    {

        private string nameField;

        private string representationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("representation")]
        public string Representation
        {
            get
            {
                return this.representationField;
            }
            set
            {
                this.representationField = value;
            }
        }
    }
}
