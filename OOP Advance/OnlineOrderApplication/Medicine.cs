using System;
namespace OnlineApplication
{
    public class Medicine
    {
        private static int s_medicineId=99;
        public string  MedicineId { get; set; }
        public string  MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateofExpiry{get;set;}
        public Medicine(string medicinename,int availablecount,double price,DateTime dateofExpiry)
        {
            s_medicineId++;
            MedicineId="MD"+s_medicineId;
            MedicineName=medicinename;
            AvailableCount=availablecount;
            Price=price;
            DateofExpiry=dateofExpiry;

        }
        public Medicine(string data)
        {
            string []values=data.Split(',');
            s_medicineId=int.Parse(values[0].Remove(0,2));
            MedicineId=values[0];
            MedicineName=values[1];
            AvailableCount=int.Parse(values[2]);
            Price=double.Parse(values[3]);
            DateofExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }
    }
}