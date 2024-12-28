using System.ComponentModel.DataAnnotations;

namespace Lab3.Model
{
    public class ReportСard
    {
        [Key]
        public long ReportCardId { get; set; }
        public string ReportCardName { get; set; }
        public string WorkshopName { get; set;}
        public double Deductions { get; set; }
        public double DaysWorked { get; set;}
        public long TariffId { get; set; }
        public Tariff? Tariff { get; set; }
        // Табель учета рабочего времени» (№ п/п; ФИО рабочего (7 разных значений); код специальности; наименование цеха (5 разных значений);
        // специальность; количество отработанных дней (10 разных значений);
        // зарплата; удержания (13% от зарплаты); сумма к выдаче (зарплата - удержания))
    }
}
