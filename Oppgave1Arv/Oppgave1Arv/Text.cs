using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomBoxes;

namespace Oppgave1Arv
{
    internal class Text : Shape
    {
        private readonly string _text;

        public Text(int x, int y, string text, Random random) : base(random)
        {
            Y = y;
            X = x;
            _text = text;
        }

        public override string GetCharacter(int row, int col)
        {
            if (row != Y || col < X || col >= X + _text.Length) return null;
            var index = col - X;
            return _text[index].ToString();
        }
    }
}
