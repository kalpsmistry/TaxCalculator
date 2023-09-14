using System;
using TaxCalculator.Models;

namespace TaxCalculator.Code
{
	public class CalculateTax
	{
        public IncomeTaxModel Calculate(IncomeTaxModel model)
		{
			decimal bandBTax = 0;
			decimal bandCTax = 0;

			// determine taxable amounts
			if (model.GrossAnnualSalary <= 5000)
				model.AnnualTaxPaid = 0;
			else if (model.GrossAnnualSalary <= 20000)
				bandBTax = (model.GrossAnnualSalary - 5000) * 0.2m;
			else
			{
				bandBTax = 15000 * 0.2m; //as over £20K annual salary
				bandCTax = (model.GrossAnnualSalary - 20000) * 0.4m;
			}

			model.AnnualTaxPaid = bandBTax + bandCTax;
			model.NetAnnualSalary = model.GrossAnnualSalary - model.AnnualTaxPaid;

			return model;
		}
	}
}

