namespace GameInterfaces
{
    public class Building : IHasValue
    {
        private string _type;
        private float _area;

        

        public Building (string _type, float _area)
        {
            this._type = Type;
            this._area = Area;
        }

        public override string ToString()
        {
            return $"[_type,-20], [Value, 8.f2], [_area, 8.f2]";
        }
    }
}