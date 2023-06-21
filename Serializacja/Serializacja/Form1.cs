using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Serializacja
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employee = new Employee()
            {
                Name = "Jan",
                ID = 1

            };
            string employeeSerialized = JsonConvert.SerializeObject(employee);
            File.WriteAllText(@"C:\JS\Serialized.json", employeeSerialized);
        }
        class Employee
        {
            public string Name { get; set; }
            public int ID { get; set; }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string employeeSerialized = File.ReadAllText(@"C:\JS\Serialized.json");
            Employee employee = JsonConvert.DeserializeObject<Employee>(employeeSerialized);
         // textBox1 = employee.Name + employee.ID;
        }

       
    }
}
