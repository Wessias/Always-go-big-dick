using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {

        public virtual void ProductName()
        {
            Console.WriteLine("This is a product");
        }
    }

    class MythicCarry : Product
    {
            public override void ProductName()
            {
                Console.WriteLine("Mythic carry");
          }
        }


    class BoostTo3k : Product
    {
        public override void ProductName()
        {
            Console.WriteLine("Boost to 3k rating");
        }
    }


    class ERPinGoldshire : Product
    {
        public override void ProductName()
        {
            Console.WriteLine("ERP in Goldshire");
        }
    }
    }
