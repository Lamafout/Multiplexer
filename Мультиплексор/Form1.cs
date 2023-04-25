namespace Мультиплексор
{
    public partial class Form1 : Form
    {
        int id0 = 0, id1 = 0, id2 = 0, id3 = 0, ia1=0, ia2=0, iv=0, iy, zero=0, one=0, two=0, three=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ia1 == 0)
            {
                button5.Text = "1" + "\n" + "(нажми, чтобы сменить)";
                ia1 = 1;
            }
            else
            {
                button5.Text = "0" + "\n" + "(нажми, чтобы сменить)";
                ia1 = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ia2 == 0)
            {
                button6.Text = "1" + "\n" + "(нажми, чтобы сменить)";
                ia2 = 1;
            }
            else
            {
                button6.Text = "0" + "\n" + "(нажми, чтобы сменить)";
                ia2 = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (iv == 0)
            {
                button7.Text = "1";
                iv = 1;
            }
            else
            {
                button7.Text = "0";
                iv = 0;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (iv == 0)
            {
                switch (id0)
                {
                    case 0:
                        d0.BackColor = Color.Black;
                        break;
                    case 1:
                        d0.BackColor = Color.Red;
                        break;
                }
                switch (id1)
                {
                    case 0:
                        d1.BackColor = Color.Black;
                        break;
                    case 1:
                        d1.BackColor = Color.Red;
                        break;
                }
                switch (id2)
                {
                    case 0:
                        d2.BackColor = Color.Black;
                        break;
                    case 1:
                        d2.BackColor = Color.Red;
                        break;
                }
                switch (id3)
                {
                    case 0:
                        d3.BackColor = Color.Black;
                        break;
                    case 1:
                        d3.BackColor = Color.Red;
                        break;
                }
                zero = (ia1 ^ 1) * (ia2 ^ 1);
                one = (ia1 ^ 1) * ia2;
                two = ia1 * (ia2 ^ 1);
                three = ia1 * ia2;
                switch (zero)
                {
                    case 0:
                        l01.BackColor = Color.Black;
                        l02.BackColor = Color.Black;
                        l03.BackColor = Color.Black;
                        break;
                    case 1:
                        l01.BackColor = Color.Red;
                        l02.BackColor = Color.Red;
                        l03.BackColor = Color.Red;
                        break;
                }
                switch (one)
                {
                    case 0:
                        l11.BackColor = Color.Black;
                        l12.BackColor = Color.Black;
                        l13.BackColor = Color.Black;
                        break;
                    case 1:
                        l11.BackColor = Color.Red;
                        l12.BackColor = Color.Red;
                        l13.BackColor = Color.Red;
                        break;
                }
                switch (two)
                {
                    case 0:
                        l21.BackColor = Color.Black;
                        l22.BackColor = Color.Black;
                        l23.BackColor = Color.Black;
                        break;
                    case 1:
                        l21.BackColor = Color.Red;
                        l22.BackColor = Color.Red;
                        l23.BackColor = Color.Red;
                        break;
                }
                switch (three)
                {
                    case 0:
                        l31.BackColor = Color.Black;
                        l32.BackColor = Color.Black;
                        l33.BackColor = Color.Black;
                        break;
                    case 1:
                        l31.BackColor = Color.Red;
                        l32.BackColor = Color.Red;
                        l33.BackColor = Color.Red;
                        break;
                }
                v1.BackColor = Color.Black;
                v2.BackColor = Color.Red;
                v3.BackColor = Color.Red;
                v4.BackColor = Color.Red;
                v5.BackColor = Color.Red;
                v6.BackColor = Color.Red;
                v7.BackColor = Color.Red;
                v8.BackColor = Color.Red;
                v9.BackColor = Color.Red;
                v10.BackColor = Color.Red;
                v11.BackColor = Color.Red;
                v12.BackColor = Color.Red;
                point1activ.Visible = true;
                point2activ.Visible = true;
                point3activ.Visible = true;
                iy = (zero * id0) ^ (one * id1) ^ (two * id2) ^ (three * id3);
                answer.Text = "y = " + iy.ToString();
            }
            else
            {
                v1.BackColor = Color.Red;
                v2.BackColor = Color.Black;
                v3.BackColor = Color.Black;
                v4.BackColor = Color.Black;
                v5.BackColor = Color.Black;
                v6.BackColor = Color.Black;
                v7.BackColor = Color.Black;
                v8.BackColor = Color.Black;
                v9.BackColor = Color.Black;
                v10.BackColor = Color.Black;
                v11.BackColor = Color.Black;
                v12.BackColor = Color.Black;
                point1activ.Visible = false;
                point2activ.Visible = false;
                point3activ.Visible = false;
                answer.Text = "y = 0";
            }
        }

        private void d1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id2 == 0)
            {
                button3.Text = "1" + "\n" + "(нажми, чтобы сменить)";
                id2 = 1;
            }
            else
            {
                button3.Text = "0" + "\n" + "(нажми, чтобы сменить)";
                id2 = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (id3 == 0)
            {
                button4.Text = "1" + "\n" + "(нажми, чтобы сменить)";
                id3 = 1;
            }
            else
            {
                button4.Text = "0" + "\n" + "(нажми, чтобы сменить)";
                id3 = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id0 == 0)
            {
                button1.Text = "1" + "\n" + "(нажми, чтобы сменить)";
                id0 = 1;
            }
            else
            {
                button1.Text = "0" + "\n" + "(нажми, чтобы сменить)";
                id0=0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id1 == 0)
            {
                button2.Text = "1" + "\n" + "(нажми, чтобы сменить)";
                id1 = 1;
            }
            else
            {
                button2.Text = "0" + "\n" + "(нажми, чтобы сменить)";
                id1 = 0;
            }
        }
    }
}