using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxCalculator.Models
{
	public class IncomeTaxModel
	{
        [Range(1000, 1000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
		public decimal GrossAnnualSalary { get; set; }
		public decimal GrossMonthlySalary => GrossAnnualSalary / 12;
		public decimal NetAnnualSalary { get; set; }
		public decimal NetMonthlySalary => NetAnnualSalary / 12;
		public decimal AnnualTaxPaid { get; set; }
		public decimal MonthlyTaxPaid => AnnualTaxPaid / 12;
	}
}

