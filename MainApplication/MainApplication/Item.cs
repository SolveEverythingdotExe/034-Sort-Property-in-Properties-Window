using System.ComponentModel;

namespace MainApplication
{
    [TypeConverter(typeof(CustomPropertySorter))]
    public class Item
    {
        [CustomOrder(1)]
        public string Text { get; set; }

        [CustomOrder(2)]
        public string Description { get; set; }

        [CustomOrder(3)]
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
    //lets build and test
}
