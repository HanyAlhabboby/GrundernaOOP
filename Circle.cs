using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundernaOOP
{
    public class Circle
    {
        float _pi = 3.141f; //här skapar vi fält både float och int
        int _Radius = 0;

      
        public Circle (int radius) //skapar constructor som hjälper oss att dela ett värde till radien
        {
            _Radius = radius; 
        }

        public float GetArea() //skapar metod som ska anropas via main
        {
            float area = _Radius * _Radius * _pi; //skapar area som ska räknas arean 
            Console.WriteLine("en Cirkel med radie " + _Radius + " har " + area + " area");
                return area; //retunerar ett värde
        }




    }
}
