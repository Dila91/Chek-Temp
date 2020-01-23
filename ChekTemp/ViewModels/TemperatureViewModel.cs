using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChekTemp.ViewModels
{
    public class TemperatureViewModel
    {
        public TemperatureViewModel()
        {
            Message = "";
        }
        public string Message { get; set; }
        public int Temperature { get; set; }
        public void CheckTemperature()
        {
            if (Temperature < 35)
            {
                Message = "You might have hypothermia";
            }
            if (Temperature > 37)
            {
                Message = "You might have a fever";
            }
            if (Temperature >=35 && Temperature <= 37)
            {
                Message = "You are in perfect health";
            }
        }
    }
}
