/* del 1
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
*/
M();
Main();

static void M() {
    int a=10, b=20;
    Bytplats(ref a, ref b);
    Console.WriteLine(a+" "+b);
}

static void Bytplats(ref int a ,ref int b) {
    int c = a;
    a = b;
    b = c;
}

static void Main(){
    Console.WriteLine("10 upphöjt till 7: " + Power(10, 7));
    Console.WriteLine("2 upphöjt till 10: " + Power(2,10));
}

static float Power(float a, int b) {
    int c = Convert.ToInt32(a);
    for (int i = 0; i <= b; i++) {
        
    }
    return c;
}