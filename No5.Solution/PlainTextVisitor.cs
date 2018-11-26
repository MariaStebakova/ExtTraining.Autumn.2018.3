using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class PlainTextVisitor: Visitor
    {
        public override string Visit(PlainText text)
        {
            return text.Text;
        }

        public override string Visit(BoldText text)
        {
            return text.Text;
        }

        public override string Visit(Hyperlink text)
        {
            return text.Text;
        }
    }
}
