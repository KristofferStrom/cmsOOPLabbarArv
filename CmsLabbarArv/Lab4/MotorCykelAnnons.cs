using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab4
{
    class MotorCykelAnnons : FordonsAnnons
    {
        private readonly int motorVolymCm3;
        private readonly DrivTyp drivTyp;

        public enum DrivTyp
        {
            Unknown,
            Kardan,
            Kedja
        };

        public MotorCykelAnnons(string rubrik, decimal pris, 
            string beskrivning, int year,int antalMil,
            int motorVolymCm3,  DrivTyp drivTyp)
            :base(rubrik, pris, beskrivning, year, antalMil)
        {
            this.motorVolymCm3 = motorVolymCm3;
            this.drivTyp = drivTyp;
        }

        public override string GetAnnonsText()
        {
            string s =  $@"MC - {rubrik} {pris} 
{beskrivning}
Årsmodell: {year}  Drivtyp:{drivTyp} Motorvolym:{motorVolymCm3}";
            
            return s;

        }
    }
}
