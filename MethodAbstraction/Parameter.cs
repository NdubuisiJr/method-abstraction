namespace MethodAbstraction {
    public class Parameter {
        public Parameter(int one, int two, int three, int four, double five, double six, double seven, double eigth, decimal nine, decimal ten) {
            ParamOne = one;
            ParamTwo = two;
            ParamThree = three;
            ParamFour = four;
            ParamFive = five;
            ParamSix = six;
            ParamSeven = seven;
            ParamEigth = eigth;
            ParamNine = nine;
            ParamTen = ten;
        }

        public override string ToString() {
            return $"This Has code will always be {GetHashCode()}";
        }

        public int ParamOne { get; set; }
        public int ParamTwo { get; set; }
        public int ParamThree { get; set; }
        public int ParamFour { get; set; }
        public double ParamFive { get; set; }
        public double ParamSix { get; set; }
        public double ParamSeven { get; set; }
        public double ParamEigth { get; set; }
        public decimal ParamNine { get; set; }
        public decimal ParamTen { get; set; }
    }
}
