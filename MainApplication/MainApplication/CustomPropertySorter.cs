using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MainApplication
{
    public class CustomPropertySorter: TypeConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            //get the property collection of the object (Item class), by default the rendering on the "Properties Window" is alphabetically
            PropertyDescriptorCollection propertyDescriptorCollection = TypeDescriptor.GetProperties(value, attributes);
            //dictionary that will store the property and CustomOrder's value
            Dictionary<PropertyDescriptor, int> propertyAndOrderCollection = new Dictionary<PropertyDescriptor, int>();

            foreach (PropertyDescriptor propertyDescriptor in propertyDescriptorCollection)
            {
                //get the CustomOrder attribute set on the property
                Attribute customOrderAttribute = propertyDescriptor.Attributes[typeof(CustomOrderAttribute)];

                //get the "Value" of the attribute if attribute was not set give it a zero value
                int customOrderValue = (customOrderAttribute == null) ? 0 : (customOrderAttribute as CustomOrderAttribute).Value;

                //store the property and CustomOrder's value in the dictionary
                propertyAndOrderCollection.Add(propertyDescriptor, customOrderValue);
            }

            //sort the property and CustomOrder collection and store it to a new dictionary of string and int
            Dictionary<string, int> sortedProperty = propertyAndOrderCollection.
                OrderBy(x => x.Value). //sort by CustomOrder first
                ThenBy(y => y.Key.Name). //then sort by Property Name
                ToDictionary(z => z.Key.Name, z => z.Value); //Dictionary<string, int> instead of <PropertyDescriptor, int>

            //return the sorted property collection which will be rendered in the "Properties Window"
            return propertyDescriptorCollection.Sort(sortedProperty.Keys.ToArray());
        }
    }
}
