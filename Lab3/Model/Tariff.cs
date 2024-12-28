using System.ComponentModel.DataAnnotations;

namespace Lab3.Model
{
    public class Tariff
    {
        [Key]
        public long TariffId { get; set; }
        public string TariffName { get; set; }
        public decimal CostTariff { get; set; }

        public ICollection<ReportСard> ReportСards { get; set; }

        //. «Тарифы» (№ п/п; код специальности (ключевое поле); название специальности; цена рабочего дня) - 7 строк. 
    }
}
