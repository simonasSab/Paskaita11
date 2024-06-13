﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;
using System.IO;

namespace Uzduotis01
{
    // Sukurti lentelę ir objektą Dviratis kuris turi Id, Modeli bei pagaminimo metus.
    // Sukurti funkcionalumą pridėti dviratį, pašalinti dviratį.
    // Sukurti lentelę dviračių nuoma, pagal identišką struktūrą, kaip tai yra realizuota su automobiliais.
    // Implementuoti nuomos registraciją Dviračiams.Funkcijas realizuoti naudojant Entity Framework.
    // Sukurti tokį patį cache'avimą kaip ir su Automobiliais naudojant MongoDb

    [Table("Bicycles")]
    public class Bicycle
    {
        [Key] [Column("ID")]
        public int ID { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("ProductionYear")]
        public int ProductionYear { get; set; }
        [NotMapped] [BsonId]
        ObjectId mongoID { get; set; }

        public Bicycle()
        {
        }
        // For getting from DB and displaying
        public Bicycle(int id, string name, int productionYear)
        {
            ID = id;
            Name = name;
            ProductionYear = productionYear;
        }
        // For searching in DB
        public Bicycle(int id)
        {
            ID = id;
            Name = "temp";
            ProductionYear = 1337;
        }
        // For creating new and storing into DB
        public Bicycle(string name, int productionYear)
        {
            ID = 0;
            Name = name;
            ProductionYear = productionYear;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            Bicycle bicycle = (Bicycle)obj;
            if (bicycle.ID == this.ID)
                return true;

            return false;
        }

        public override string ToString()
        {
            return $"ID {ID:000} {Name} {ProductionYear}";
        }
    }
}
