using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class DocumentPartExtensions
    {
        public string ToHtml(this DocumentPart documentPart)
        {

        }

        public abstract string ToPlainText();

        public abstract string ToLaTeX();
    }
}
