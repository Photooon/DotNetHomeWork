﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch03
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer()
        {
            this.Name = "";
            this.Age = -1;
        }

        public Customer(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}";
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer == null || this.Name != customer.Name || this.Age != customer.Age) return false;
            return true;
        }

        public override int GetHashCode()
        {
            var bytes = Encoding.Default.GetBytes(Name);
            int nameInt = 0;
            foreach (var b in bytes)
            {
                nameInt = nameInt * 10 + Convert.ToInt32(b);
            }
            return nameInt + Age;
        }
    }
}
