namespace CityManager1
{
    public class Building : IHasValue
    {
        public float Value {get;}
        private string _type;
        private float _area;


        public Building (string _type, float _value, float _area)
        {
            this._type = _type;
            this._area = _area;
            Value = _value;
        }

        public override string ToString()
        {
            return $"{_type,-20}, {Value, 8:f2}, {_area, 8:f2}";
        }

        public bool Equals (IHasValue other)
        {
            if (other == null) return false;
            return Value == other.Value;
        }
    }
}