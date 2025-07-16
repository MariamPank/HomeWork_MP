using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_16
{
    public class ProductWeight : IComparable<ProductWeight>
    {
        public string Name { get; private set; }
        public Unit UnitType { get; private set; }
        public decimal Weight { get; private set; }

        public ProductWeight(string name, Unit unitType, decimal weight)
        {
            Name = name;
            UnitType = unitType;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name} Weight - {Weight} {UnitType}";
        }

        public void UnitCheck(ProductWeight anotherOne)
        {
            if (this.UnitType != anotherOne.UnitType)
            {
                throw new ArgumentException("Please compare products with the same unit types");
            }
        }

        public int CompareTo(ProductWeight anotherOne)
        {
            UnitCheck(anotherOne);
            return this.Weight.CompareTo(anotherOne.Weight);
        }

        public static ProductWeight operator +(ProductWeight a, ProductWeight b)
        {
            a.UnitCheck(b);
            return new ProductWeight($"{a.Name}+{b.Name}", a.UnitType, a.Weight + b.Weight);
        }

        public static bool operator == (ProductWeight a, ProductWeight b)
        {
            if(a.Weight == b.Weight && a.UnitType == b.UnitType)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(ProductWeight a, ProductWeight b) {

            if (a.Weight != b.Weight || a.UnitType != b.UnitType)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(ProductWeight a, ProductWeight b)
        {
            a.UnitCheck(b);
            return a.Weight < b.Weight;
        }

        public static bool operator >(ProductWeight a, ProductWeight b)
        {
            a.UnitCheck(b);
            return a.Weight > b.Weight;
        }

    }
}
