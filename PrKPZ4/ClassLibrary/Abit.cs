using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ABit
    {
        private string subject;
        private int bal;
        public ABit(string subject = "", int bal = 0)
        {
            this.subject = subject;
            this.bal = bal;
        }
        public void Init_Abit()
        {
            System.Console.WriteLine("Введiть предмет");
 
            this.subject = System.Console.ReadLine();
            
            System.Console.WriteLine("Введiть бал");
            
            this.bal = Convert.ToInt32(System.Console.ReadLine());
        }
        ///////////////////////////////////////////////////
        ///
        
        
        
        public ABit(ABit ABit)
        
        {
        ////
            this.subject = ABit.subject;
            this.bal = ABit.bal;
        }
        public ABit(int bal)
        {
            this.subject = "";
            this.bal = bal;
        }
        public void Set_subject(string subject)
        {
            this.subject = subject;
        }
        public void Set_bal(int bal)
        {
            this.bal = bal;
        }
        public string Get_subject()
        {
            return subject;
        }
        ////////////////////////////////////////////////////////
        public int Get_bal() { return bal; }
      
        public void Show_Ed()
        {
            System.Console.WriteLine("Предмет - " + subject + " | бал за семестр - " + bal);
        }
    }
}