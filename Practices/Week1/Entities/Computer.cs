using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Enums;

namespace Week1.Entities
{
    internal class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public int StorageSize { get; set; }
        public CapacitySizeType StorageSizeType { get; set; }

        public Computer()
        {
            Random random = new Random();
            Id = random.Next(10000, int.MaxValue);
        }

        public Computer(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;
        }

        public Computer(string brand, string model, string cPU, string ram, string storage, int storageSize, CapacitySizeType storageSizeType) : this(brand, model)
        {
            //Id, Brand and Model are assignmented in the second constructor
            CPU = cPU;
            RAM = ram;
            StorageSizeType = storageSizeType;
            StorageSize = storageSize;
            Storage = storage;
        }


    }
}
