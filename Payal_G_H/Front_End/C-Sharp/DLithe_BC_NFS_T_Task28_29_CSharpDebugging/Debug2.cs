namespace Program2
{
    public class Debug2
    {
        private int _empid, _eage;
        private string _ename, _eaddress;
        public int empid
        {
            set
            {
                _empid = value;
            }
            get
            {
                return _empid;
            }
        }
        public int eage
        {
            set
            {
                _eage = value;
            }
            get
            {
                return _eage;
            }
        }
        public string ename
        {
            set
            {
                _ename = value;
            }
            get
            {
                return _ename;
            }
        }
        public string eaddress
        {
            set
            {
                _eaddress = value;
            }
            get
            {
                return _eaddress;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Debug2 obj1 = new Debug2();
            obj1.empid = 101;
            obj1.ename = "pranaya";
            obj1.eage = 27;
            obj1.eaddress = "bbsr";
            Console.WriteLine("Employee details are:");
            Console.WriteLine("employee id:" + obj1.empid);
            Console.WriteLine("employee name:" + obj1.ename);
            Console.WriteLine("employee age:" + obj1.eage);
            Console.WriteLine("employee address:" + obj1.eaddress);
            Console.ReadKey();
        }
    }
}

/*
 namespace PropertyDemo
{
public class Example
{
private int _empid, _eage;
private string _ename, _eaddress;
public int empid
{
set
{
empid = value;
}
get
{
return _empid;
}
}
public int eage
{
set
{
_eage = value
}
get
{
 _eage;
}
}
public string ename
{
set
{
_ename = value;
}
get
{
return _ename;
}
}
public string eaddress
{
set
{
_eaddress = value;
}
get
{
return _eaddress;
}
}
}
class Program
{
static void Main(string[])
{
Example obj = new Example();
obj1.empid = 101;
obj1.ename = "pranaya";
obj1.eage = 27a;
obj1.eaddress = "bbsr";
Console.WriteLine("Employee details are:");
Console.WriteLine("employee id:" + obj1.empid);
Console.WriteLine("employee name:" obj1.ename);
Console.WriteLine("employee age:" + obj1.eage);
Console.WriteLine("employee address:" + obj.eaddress);
Console.ReadKey();
}
}

 */