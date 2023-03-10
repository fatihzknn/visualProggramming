﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Fatih"},
                new Student{FirstName = "Yunus Emre"},
                new Person{FirstName = "Kaan"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine(); 
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    // Inheritance da iki adet baba class kullanılamaz kalıtım yaparken
    // abstruct classlarda inheritance kullanılır genelde
    // 
    class Person2
    {
        
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
