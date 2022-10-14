using System;
namespace MultiLevelInheritance
{
    public interface IMarkDetail
    {
        //No feild
        int Physics { get; set; }// Propeerty declaration only allowed
        int Chemistry { get; set; }
        int Maths { get; set; }
        int Total { get; set; }
        double Average { get; set; }
        //No constrctor and object
        void GetMark(int physics,int chemistry,int maths);

        void Calculate();//Method declaration only allowed
        void ShowMark();
    }
}