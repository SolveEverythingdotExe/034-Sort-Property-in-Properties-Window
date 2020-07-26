using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    //This attribute will be used to order the rendering of the property in the "Properties Window"
    //If the property was not assigned it will be automatically be indexed as 0, but negative numbers is acceptable
    //The sorting will be starting from negative numbers, zero then positive numbers

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)] //ENHANCEMENT =====> limit only the usage of this attribute to "Property"
    public class CustomOrderAttribute: Attribute
    {
        //property that will store the value set into this attribute
        public int Value { get; }

        //constructor
        public CustomOrderAttribute(int value)
        {
            //set the value
            Value = value;
        }
    }
}
