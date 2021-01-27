using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteWF
{
    public partial class Form1 : Form
    {
        Label a = new Label()
            {
                Text = "Teste",
                Location = new Point(10, 70),
                ForeColor = Color.Red,
                 
            };
            
            
        Button b = new Button(){
                Text = "teste",
                Width = 100,
                Height = 40,
                Visible = true,
                BackColor = Color.White,
                Location = new Point(10, 10)
            };       

        int cont = 1;       
            
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Silver;

            b.Click += new EventHandler(b_click);
                
            Controls.Add(a);
            Controls.Add(b);
            
            
        }
        
        private void b_click(Object sender, EventArgs e ){
            //MessageBox.Show("Clicou!!!"); 
            a.Text = "Clicou " + cont + " vezes";
            if(cont % 2 == 0){
                a.Font = new Font(a.Font, FontStyle.Bold);
                a.Size = new System.Drawing.Size(a.Size.Height * 2, a.Size.Width * 2);
                a.AutoSize = true;
                Controls.Add(a);
                a.ForeColor = Color.Green;
            }
            else{
                a.Font= new Font(a.Font, FontStyle.Bold);
                a.Size = new System.Drawing.Size(a.Size.Height * 2, a.Size.Width * 2);
                a.AutoSize = true;
                Controls.Add(a);
                a.ForeColor = Color.Red;
            }
            cont++;            
        }

    }
}
