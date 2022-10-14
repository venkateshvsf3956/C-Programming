using System;
namespace Interface
{
    public interface IRectangle
    {
         double Length { get; set; }
        double Breath { get; set; }

        void CalculateArea(); 
        
    }

    
}