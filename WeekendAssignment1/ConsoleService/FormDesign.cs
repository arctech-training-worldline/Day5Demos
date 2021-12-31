using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendAssignment1.ConsoleService
{
    internal class FormDesign : IEnumerable<FormLine>
    {
        private readonly int _left, _top;

        public FormDesign(int left, int top)
        {
            _left = left;
            _top = top;
        }

        public List<string> Lines { get; set; }

        public IEnumerator<FormLine> GetEnumerator()
        {
            
            var rowIndex = _top;

            foreach (var line in Lines)
            {
                yield return new FormLine { Line = line, Left = _left, Top = rowIndex++ };
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
