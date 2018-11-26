using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public abstract class Visitor
    {
        public string Visit(DocumentPart text) => Visit((dynamic)text);

        public abstract string Visit(PlainText text);
        public abstract string Visit(BoldText text);
        public abstract string Visit(Hyperlink text);
    }
}
