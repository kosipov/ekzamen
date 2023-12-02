using System;
using System.ComponentModel.DataAnnotations;

public class ValidationHelper
{
    public static bool IsValidEmail(string email)
    {
        return new EmailAddressAttribute().IsValid(email);
    }

    public static decimal GetPriceWithDiscount(string price, decimal discount)
    {
        if (decimal.TryParse(price, out decimal result))
        {
            return result * (1 - discount);
        }
        else
        {
            throw new ArgumentException("Invalid price format.");
        }
    }
}
