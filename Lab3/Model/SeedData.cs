using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Model
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.Tariffs.Count() == 0&&
                context.ReportСards.Count() == 0) 
            {
                new Tariff { TariffName = "Отчислен", CostTariff = 100 };
                new Tariff { TariffName = "ТипУмный", CostTariff = 150 };
                new Tariff { TariffName = "Умный1", CostTariff = 200 };
                new Tariff { TariffName = "Умный2", CostTariff = 200 };
                new Tariff { TariffName = "Умный3", CostTariff = 200 };
                new Tariff { TariffName = "Умный4", CostTariff = 200 };
                new Tariff { TariffName = "Умный5", CostTariff = 200 };
            };


            context.ReportСards.AddRange(
                new ReportСard
                {
                    ReportCardName = "Дурка",
                    WorkshopName = "Балда",
                    DaysWorked = 1,
                    Deductions = 0.13,
                    TariffId = 1
                },
                  new ReportСard
                  {
                      ReportCardName = "Хомячков",
                      WorkshopName = "Балда",
                      DaysWorked = 2,
                      Deductions = 0.13,
                      TariffId = 2
                  },
                    new ReportСard
                    {
                        ReportCardName = "Кальмаров",
                        WorkshopName = "Балда",
                        DaysWorked = 3,
                        Deductions = 0.13,
                        TariffId = 3
                    },
                      new ReportСard
                      {
                          ReportCardName = "Тема",
                          WorkshopName = "Балда",
                          DaysWorked = 4,
                          Deductions = 0.13,
                          TariffId = 4
                      },
                        new ReportСard
                        {
                            ReportCardName = "Некент",
                            WorkshopName = "Балда",
                            DaysWorked = 5,
                            Deductions = 0.13,
                            TariffId = 5
                        },
                          new ReportСard
                          {
                              ReportCardName = "Сокол",
                              WorkshopName = "Балда",
                              DaysWorked = 6,
                              Deductions = 0.13,
                              TariffId = 6
                          },
                            new ReportСard
                            {
                                ReportCardName = "Тошик",
                                WorkshopName = "Балда",
                                DaysWorked = 7,
                                Deductions = 0.13,
                                TariffId = 7
                            }
                );
            context.SaveChanges();
          
        }
    }
}
