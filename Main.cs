using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSloon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        DateBase db = new DateBase();

        private void btn_closed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region перемещение формы
        Point last_point; //для перетаскивания окна
        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }
        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            listBox_main.Items.Add($"Название: \t Где купить: \t Стоимость:");
            foreach (var b in db.GetCars())
            {
                listBox_main.Items.Add($"{b.ModelName} \t {b.Location} \t {b.Coast} руб.");
            }
            listBox_main.SelectedIndex = 1;
        }

        private void listBox_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var b in db.GetCars(1, listBox_main.SelectedIndex))
            {
                label_box.Text = b.Box;
                label_engine.Text = b.Engine + "л.с.";
                label_privod.Text = b.Privod;
                label_racxod.Text = b.Rashod + "л";
                label_speed.Text = b.MaxSpeed + "км/ч";
                label_time.Text = b.Razgin + "cек.";
            }

        }
    }
}
