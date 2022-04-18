using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModExam
{
    public partial class Книжный
    {
        public string Header
        {
            get
            {
                return "Название: " + Название + "| " + "Жанр: " + Жанр;
            }
        }
        public string KolvoMagaz
        {
            get
            {
                if (Колво_магаз > 0)
                {
                    if (Колво_магаз > 4)
                    {
                        return "Много";
                    }
                    else return Convert.ToString(Колво_магаз);
                }
                else return "Нет";
                
                
                        
            }
        }
        public string KolvoSclad
        {
            get
            {
                if (Колво_склад > 0)
                {
                    if (Колво_склад > 4)
                    {
                        return "Много";
                    }
                    else return Convert.ToString(Колво_склад);
                }
                else return "Нет";

            }
        }
    }
}