namespace Kristof.Kata.SecurityManagement
{
    public struct Probability
    {
/*
                                                   Either:P(A) + P(B) - P(A)P(B)
                                                   CombinedWith: P(A)P(B)
                                                   InverseOf: 1 - P(A)
                                                */
        private readonly decimal _value;

        public Probability(decimal value)
        {
            _value = value;
        }

        public Probability CombinedWith(Probability p)
        {
            return new Probability(p._value*_value);
        }

        public Probability InverseOf(Probability p)
        {
            return new Probability(1 - _value);
        }

        public Probability Either(Probability other)
        {
            return new Probability(_value + other._value - _value*other._value);
        }

        public override string ToString()
        {
            return _value.ToString("F");
        }
    }
}