using System;

////Indexers = A way to access elements in a calss that represents a list of values

////Demo1
//var array = new int[5];
////This is an Indexer
////Notice that we can call the first number of the Index here 
//array[0]= 1;

////Demo2
////Here, we have a list of int
var list = new List<int>();
////Again, using a Indexer, we can access the first element in the list
list[0]= 1;

////Collection Semantics is one of the reasons for Indexers
var cookie = new HttpCookie();
cookie.Expire = DateTime.Today.AddDays(5);

cookie["name"] = "Mosh";
cookie.SetItem("name", "June");

var name = cookie["name"];
var name = cookie.GetItem("name");


namespace CP3.Indexers
{
    public class IndexersEx
    {
        public IndexersEx()
        {
        }
    }
}
