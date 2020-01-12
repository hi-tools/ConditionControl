using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionControl
{
    public enum NoeType
    {
        NoeString = 0,
        Number = 1,
        NoeDate = 2
    }

    public enum NoeControl
    {
        txtString = 0,
        txtStringTwoCol =1,
        txtNumber = 2,
        txtNumberTwoCol =3 ,
        Combo =4,
        Date =5,
        DateTwoCol =6,
        None = 7
    }
    public class Operand // عملگر => و ، یا ،...
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
    }

    public class Fields // 
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
        public NoeType Noe { get; set; }
    }

    public class Decide
    {
        public int ID { get; set; }
        public string  Title { get; set; }
        public string Name { get; set; }
        public NoeType Noe { get; set; }
        public NoeControl noeControl { get; set; }
    }

    public class SqlCondition
    {
        public int ID { get; set; }
        public string StrSql { get; set; }
        public string strPersian { get; set; }
    }
}
