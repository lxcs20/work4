using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace work4
{
    public partial class frmEmployee : Form
    {
        Dbconnection Q = new Dbconnection();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btEditData_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            String name, surname, phone, email, address, noted;
            name = txtempName.Text.ToString();
            surname = txtempSurname.Text.ToString();
            phone = txtempPhone.Text.ToString();
            email = txtempEmail.Text.ToString();
            address = txtempAddress.Text.ToString();
            noted = txtNote.Text.ToString();
            Q.Query("insert into tbEmployee (empName,empSurname,empPhone,empEmail,empAddress,Note) " +
            "values ('" + name + "','" + surname + "','" + phone + "','" + email + "','" + address + "','" + noted + "')");
            MessageBox.Show("Emplpyee added!!!");

        }
    }
}
