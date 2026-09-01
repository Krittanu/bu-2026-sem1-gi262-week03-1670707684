using System.Security.Cryptography.X509Certificates;
using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string Name;
        public float speed;
        public string color;

        public void Move()
        {
            Debug.Log("Car is Moving");
        }

        public void Turn()
        {
            Debug.Log("Car is turning");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            // Student code start HERE ...

            Car car1 = new Car();
            car1.Name = "Lamborghini";
            Debug.Log(car1.Name);
            car1.Move();
            car1.Turn();

            Car car2 = new();
            car2.Name = "Toyota";
            Debug.Log(car2.Name);

            // Student code ends HERE 
        }
    }
}
