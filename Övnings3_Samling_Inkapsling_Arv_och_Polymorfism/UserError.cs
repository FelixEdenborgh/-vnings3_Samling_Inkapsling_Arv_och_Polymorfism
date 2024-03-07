using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övnings3_Samling_Inkapsling_Arv_och_Polymorfism
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }


    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a\r\nnumeric input in a text only field. This fired an error!”";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "“You tried to use a text\r\ninput in a numeric only field. This fired an error!”";
        }
    }
}
