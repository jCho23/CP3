////Inheritance = A kind of relationship between two classes that allows one to inherit code from the other
////*Benefits
//// 1) Code Re-USe = Encapsulates one classs and use that later for another classs
//// 2) Polymorphic behavior = 

////Syntax Inheritance Demo
//public class PresentationObject
//{
    ////Common Shared Code    
//}

//public class Text:PresentationObject
//{
    ////Code Specific to Text 
//}

using System;
namespace CP3.AssociationClasses
{
	////Here, we are creating a Class called PresentationObject, which is the Parent Class
    public class PresentationObject
    {
        ////Defining Properties
        public int Width { get; set; }
        public int Height { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
