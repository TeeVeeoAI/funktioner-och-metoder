void Main() {
    double radie = 2.4;
    Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
    Console.WriteLine("Cirkelns omkrets: " + CirkelArea(radie));
}

double CirkelOmkrets(double r) {
    double O = (r+r) * Math.PI;
    return O;
}

double CirkelArea(double r) {
    double A = Math.Pow(r, 2)*Math.PI;
    return A;
} 

float Medelvärde(float a, float b, float c) {
    return (a + b + c) / 3;
}

Main();
float a = 448965, b = 636, c = 86235;
Console.WriteLine("Medelvärdet är: " + a + ", " + b + ", " + c); 
Console.WriteLine(Medelvärde(a, b, c));