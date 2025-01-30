using System;

namespace FakeXrmEasy;

public class EmptyConnectionStringException: Exception 
{
    public EmptyConnectionStringException(): base("Please create an XrmRealContext class using the connection string constructor.")
    {
        
    }
}