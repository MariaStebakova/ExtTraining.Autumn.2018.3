using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class HyperlinkVisitor: Visitor
    {
        public string Url { get; set; }

        public override string Visit(PlainText text)
        {
            return "<a href=\"" + this.Url + "\">" + text.Text + "</a>";
        }

        public override string Visit(BoldText text)
        {
            return text.Text + " [" + this.Url + "]";
        }

        public override string Visit(Hyperlink text)
        {
            return "\\href{" + this.Url + "}{" + text.Text + "}";
        }
    }
}
