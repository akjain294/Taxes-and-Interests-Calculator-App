using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Login
{
    public interface IWirteService
    {
        void wirteFile(string FileName,int  TotalIncome,int incometax);

        string[] Readfile(string FileName);
    }

    public class test
    {
        public string Item { get; set; }
    }
}
