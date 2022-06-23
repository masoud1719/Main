namespace Excitation_Coil
{
    public partial class Exsitationcoil : Form
    {
        public Exsitationcoil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                maskedTextBox13.Enabled = false;
            else
                maskedTextBox13.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            maskedTextBox8.Enabled = false;
            maskedTextBox9.Enabled = false;

            if (checkBox1.Checked)
            {
                if (comboBox2.Text == "Round Wire")
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                }
                else
                {
                    maskedTextBox8.Enabled = true;
                }
            }
            else
            {
                maskedTextBox9.Enabled = true;

                if (Double.Parse(textBox1.Text) < 100)
                    maskedTextBox9.Text = "0.75";
                else
                    maskedTextBox9.Text = "0.50";

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox3.Enabled = false;
            maskedTextBox4.Enabled = false;
            //maskedTextBox5.Enabled = false;
            maskedTextBox6.Enabled = false;
            maskedTextBox7.Enabled = false;


            if (comboBox2.Text == "Round Wire")
            {
                maskedTextBox3.Enabled = true;
                maskedTextBox4.Enabled = true;
            }
            else
            {
                //maskedTextBox5.Enabled = true;
                maskedTextBox6.Enabled = true;
                maskedTextBox7.Enabled = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox12.Enabled = false;

            if (radioButton7.Checked)
                maskedTextBox12.Enabled = true;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox10.Enabled = false;
            maskedTextBox11.Enabled = false;
            comboBox3.Enabled = false;

            if (radioButton8.Checked)
                maskedTextBox10.Enabled = true;
            else if (radioButton9.Checked)
                maskedTextBox11.Enabled = true;
            else
                comboBox3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vc;
            double v = Double.Parse(textBox1.Text);
            double p = Double.Parse(maskedTextBox1.Text);

            if (comboBox1.Text == "Generator")


                vc = (0.8 * v) / p;


            else
                vc = v / p;

            if (radioButton4.Checked)
            {


                double VoltDrop = Double.Parse(maskedTextBox13.Text);
                vc = (v - VoltDrop) / p;
            }


            double dc;
            if (radioButton5.Checked)
            {


                if (comboBox2.Text == "Round Wire")
                    dc = 0.5;


                else
                    dc = 5;


            }
            else if (radioButton6.Checked)
            {
                dc = 0;
            }
            else
            {


                dc = Double.Parse(maskedTextBox12.Text);


            }

            double ti = 0;
            if (radioButton8.Checked)
                ti = Double.Parse(maskedTextBox10.Text);



            // Insulation on wire diameter
            double iwd = 0;
            if (radioButton9.Checked)
                iwd = Double.Parse(maskedTextBox11.Text);



            var H = Double.Parse(maskedTextBox5.Text);




            double lmt;
            if (comboBox2.Text == "Round Wire")
            {


                var Di = Double.Parse(maskedTextBox4.Text);
                var Do = Double.Parse(maskedTextBox3.Text);



                lmt = Math.PI * ((Di + Do) / 2);
            }
            else
            {
                var L = Double.Parse(maskedTextBox7.Text);
                var W = Double.Parse(maskedTextBox6.Text);



                lmt = 2 * (L + W) + Math.PI * (dc + (2 * ti));
            }


            double tm = Double.Parse(textBox2.Text);
            double tr = Double.Parse(maskedTextBox2.Text);




            double ro = 2.1 * Math.Pow(10, -6);

            if (tm + tr != 75)
                ro = ro * (234.5 + tm + tr) / (234.5 + 75);



            double mmf = Double.Parse(txt_mmf.Text);



            double az = ((ro * lmt * mmf) / vc) * 100;
             // az......mm^2



            double d = Math.Sqrt(4 * az / Math.PI);



            double di;
            if (radioButton8.Checked)
                di = d + (2 * ti);


            else if (radioButton9.Checked)
                di = d + iwd;


            else
                di = 0; // todo calc from SWG table!



            double ssf;
            if (!checkBox1.Checked)
            {
                ssf = Double.Parse(maskedTextBox9.Text);


            }
            else
            {
                if (comboBox2.Text == "Round Wire")
                {

                    if (radioButton1.Checked)
                        ssf = 0.906 * Math.Pow(d / di, 2);


                    else

                        ssf = 0.785 * Math.Pow(d / di, 2);
                }
                else
                {
                    ssf = Double.Parse(maskedTextBox8.Text); // check shavad.
                }
            }


            double Nh = Math.Round(H / (di / 10));
            double Nd = Math.Round(dc / (di / 10));



            double N = Nh * Nd;


            // watt
            double P = (ro * lmt * mmf * mmf) / ((az * Math.Pow(10, -2) * N));



            double I = P / vc;


            // cm^2
            double C = (lmt + Math.PI * dc) * H;



            double HD;
            if (maskedTextBox14.Text != "")
                HD = Double.Parse(maskedTextBox14.Text);


            else
                HD = P / C;


            // ohm
            double R = (ro * lmt * N) / (az *Math.Pow(10, -2));



            double mmf_new = N * I;



            dgv_result_dim.Rows.Clear();
            dgv_result_elec.Rows.Clear();



            dgv_result_dim.Rows.Add("Height", H + " cm");
            dgv_result_dim.Rows.Add("dc", dc);
            dgv_result_dim.Rows.Add("ssf", ssf);



            dgv_result_elec.Rows.Add("vc", Math.Round(vc, 2) + "    V");
            dgv_result_elec.Rows.Add("lmt", Math.Round(lmt, 2) + "   cm");
            dgv_result_elec.Rows.Add("az", Math.Round(lmt, 2) + "   mm^2");
            dgv_result_elec.Rows.Add("d", Math.Round(d, 2) + "   mm");
            dgv_result_elec.Rows.Add("di",Math.Round( di, 2) + "   mm");
            dgv_result_elec.Rows.Add("Nh", Nh);
            dgv_result_elec.Rows.Add("Nd", Nd);
            dgv_result_elec.Rows.Add("N", N);
            dgv_result_elec.Rows.Add("R", Math.Round(R, 2) + "   ohm");
            dgv_result_elec.Rows.Add("I", Math.Round(I, 2) + "   A");
            dgv_result_elec.Rows.Add("P", Math.Round(P, 2) + "   watt");
            dgv_result_elec.Rows.Add("C", Math.Round(C, 2) + "   cm^2");
            dgv_result_elec.Rows.Add("HD", Math.Round(HD, 3) + "   watt/cm^2");
            dgv_result_elec.Rows.Add("mmf new", Math.Round(mmf_new, 4) + "   A");
            
        }

        private void dgv_result_dim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}