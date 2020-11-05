using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOS
{
    struct Step
    {
        public Dictionary<string, Color> OutputString { get; set; }

        public int NumberOfUndosInRichTextBox { get; set; }

        public bool PageFault { get; set; }
    }
}