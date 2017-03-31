using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Messenger.Models
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class LocaleCode
    {

        private LocaleCodeStandard standardField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("standard")]
        public LocaleCodeStandard Standard
        {
            get
            {
                return this.standardField;
            }
            set
            {
                this.standardField = value;
            }
        }
    }
}
