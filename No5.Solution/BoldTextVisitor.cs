using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class BoldTextVisitor: Visitor
    {
        public override string Visit(PlainText text)
        {
            return "<b>" + text.Text + "</b>";
        }

        public override string Visit(BoldText text)
        {
            return "**" + text.Text + "**";
        }

        public override string Visit(Hyperlink text)
        {
            return "\\textbf{" + text.Text + "}";
        }
    }
}
