using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElectroStore.Models
{
    public class GoodDbIntializer : DropCreateDatabaseAlways<GoodContex>
    {
        protected override void Seed(GoodContex db)
        {
            db.Cabels.Add(new Cabel
            {
                Mark = "ВВП",
                CrossSection = new WireCrossSection(3, 2.5).ToString(),
                Producer = "Одессакабель",
                Price = 14.25
            });

            db.Cabels.Add(new Cabel
            {
                Mark = "ВВГ",
                CrossSection = new WireCrossSection(4, 16.0).ToString(),
                Producer = "Запоріжжя кабель",
                Price = 33.76
            });

            db.Cabels.Add(new Cabel
            {
                Mark = "ШВВП",
                CrossSection = new WireCrossSection(2, 4.0).ToString(),
                Producer = "Одесса ГОСТ",
                Price = 17.25
            });

            db.Cabels.Add(new Cabel
            {
                Mark = "RG-6U",
                CrossSection = new WireCrossSection(1, 0.75).ToString(),
                Producer = "УкрАско",
                Price = 4.25
            });

            base.Seed(db);
        }
    }
}