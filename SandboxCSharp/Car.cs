using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxCSharp
{
    class Car
    {
        // this is a field. this is basically like internal state.
        private bool trunkOpen;

        // this is how we invoke one of the other constructors.
        public Car()
            : this(false)
        {
            Console.WriteLine("default constructor");
        }

        public Car(bool trunkOpen)
        {
            Console.WriteLine("normal constructor");
        }

        // This passes an int by reference.
        public void AddFiveRef(ref int number)
        {
            number = number + 5;
        }

        public void AddString(string s)
        {
            s = s + "hahaha";
        }

        public void AddStringRef(ref string s)
        {
            s = s + "ref hahaha";
        }

        public void CreateLicensePlate(out LicensePlate myLicense)
        {
            myLicense = new LicensePlate();
            myLicense.number = 3;
        }

        public void ReadLicensePlate(LicensePlate input)
        {

        }

        // This is a property
        public bool TrunkOpen
        {
            get
            {
                return trunkOpen;
            }
            set
            {
                // the value is the value that this property is getting set to.
                trunkOpen = value;
            }
        }

        // This property autogenerates a private field for us.
        public int id { get; set; }
    }
}
