using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWork.DataBase;

namespace TestWork
{
    public partial class TemplateBuilder : Form
    {
        public TemplateBuilder()
        {
            InitializeComponent();
            string dbPath = @"C:\Users\1\source\repos\TestWork\TestWork\DataBase\test_work.sqlite";
            DBInitializer.Initialize(dbPath);
        }
    }
}
