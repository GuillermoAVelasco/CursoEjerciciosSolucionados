using static _11_Ejercicios_Delegados_y_metodos_anonimos.Program;

namespace _11_Ejercicios_Delegados_y_metodos_anonimos
{
    class Program
    {
        
        //1)	Escriba 3 delegados con distinta firma

        public delegate int OperacionesComunes(int i, int v);
        public delegate double OperacionesRaizCuadrada(int i);
        public delegate decimal OperacionesPotenciaCuadrada(int i);
        
        //4)	Convierta los 3 métodos del paso 2 en Func<T > o Action<T> según corresponda.
        public static Func<int, int, int> OperacionSuma=(x,y)=> x+y;
        public static Func<int, int, int> OperacionResta = (x, y) => x - y;
        public static Func<int,double> OperacionRaiz = x => Math.Sqrt(x);
        public static Func<int, decimal> OperacionPotencia = x => Convert.ToDecimal(Math.Pow(x,2));
        public static Action<string> MuestraMensaje = x => Console.WriteLine("Mensaje con Action:"+x);


        static void Main(string[] args)
        {

            //ejecucion con delegados
            
            OperacionesComunes suma = Suma;
            Console.WriteLine("Operacion con Delegados Suma: 2+2: "+suma(2, 2));

            OperacionesComunes resta = Resta;
            Console.WriteLine("Operacion con Delegados Resta: 2-2: " + resta(2, 2));

            OperacionesRaizCuadrada raiz = RaizCuadrada;
            Console.WriteLine("Operacion con Raiz cuadrada de 8: "+raiz(8));

            OperacionesPotenciaCuadrada potencia = PotenciaCuadrada;
            Console.WriteLine("Operacion con Potencia al 2: 2 a la 2: " + potencia(2));
            
            //3)	Convierta los 3 métodos creados en el paso anterior en métodos anónimos.
            
            suma = delegate (int x, int y)
            {
                return x + y;
            };

            resta = delegate (int x, int y)
            {
                return x - y;
            };

            raiz = delegate (int x)
            {
                return Math.Sqrt(x);
            };

            potencia = delegate (int x)
            {
                return Convert.ToDecimal(Math.Pow(x, 2));
            };
            
            /*
            suma = (int x, int y) => x + y;
            resta = (int x, int y) => x - y;
            raiz = (int x) => Math.Sqrt(x);
            potencia = (int x) => Convert.ToDecimal(Math.Pow(x,2));
            */
            
            Console.WriteLine();
            Console.WriteLine(("Convirtiendo los metodos en anonimos"));
            Console.WriteLine("Operacion con Delegados Suma: 2+2: " + suma(2, 2));
            Console.WriteLine("Operacion con Delegados Resta: 2-2: " + resta(2, 2));
            Console.WriteLine("Operacion con Raiz cuadrada de 8: " + raiz(8));
            Console.WriteLine("Operacion con Potencia al 2: 2 a la 2: " + potencia(2));

            //4)	Convierta los 3 métodos del paso 2 en Func<T > o Action<T> según corresponda. 
            Console.WriteLine();
            Console.WriteLine("Convierta los 3 métodos del paso 2 en Func<T > o Action<T> según corresponda.");
            Console.WriteLine("Operacion con Func Suma:" + OperacionSuma.Invoke(2,2));
            Console.WriteLine("Operacion con Func Resta:" + OperacionResta.Invoke(2, 2));
            Console.WriteLine("Operacion con Func Raiz:" + OperacionRaiz.Invoke(8));
            Console.WriteLine("Operacion con Func Potencia:" + OperacionPotencia.Invoke(2));
            MuestraMensaje("Algo va aca");

        }

        //2)	Escriba 3 métodos que cumplan con la firma de los delegados creados en el paso 1.
        public static int Suma(int i, int v)
        {
            return i + v;
        }

        public static int Resta(int i, int v)
        {
            return i - v;
        }

        public static double RaizCuadrada(int i)
        {
            return Math.Sqrt(i);
        }

        public static decimal PotenciaCuadrada(int i)
        {
            return Convert.ToDecimal(Math.Pow(i,2));
        }
    }
}