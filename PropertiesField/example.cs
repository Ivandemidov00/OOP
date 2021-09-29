using System;

namespace PropertiesField
{
    public class example
    {
        private String name;
        
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private Int32 age { get; set; } = 0;
    }

    public abstract class people
    {
        public abstract String Status
        {
            get;
            set;
        }
    }

    public class worker : people
    {
        private String status;
        private Int32 age;
        public Int32 Age { get; set; }
        public override string Status { get=>status; set=>status=age<18?"Kinder":"worker"; }
    }
}