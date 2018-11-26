﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    public class Document
    {
        private readonly List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string ToHtml()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToHtml()}\n";
            }

            return output;
        }

        public string ToPlainText()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToPlainText()}\n";
            }

            return output;
        }

        public string ToLaTeX()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToLaTeX()}\n";
            }

            return output;
        }
    }

    //В качестве реализации был выбран паттерн проектирования Visitor, тк нужно добавить новые операции к классам, не изменяя их,
    //при этом классы имеют общую структуру
}
