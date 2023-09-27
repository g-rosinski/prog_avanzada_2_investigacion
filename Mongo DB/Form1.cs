using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace Mongo_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoDBCsharp.Clases.CConexion objetoconexion = new MongoDBCsharp.Clases.CConexion();
            objetoconexion.establecerConexion();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MongoDBCsharp.Clases.CConexion objetoconexionRedis = new MongoDBCsharp.Clases.CConexion();
            objetoconexionRedis.establecerConexionRedis();

        }
    }
}
