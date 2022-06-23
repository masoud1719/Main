using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testmna
{
    public partial class Plunger : Form
    {
        public Plunger(double force, double stroke, bool isMass)
        {
            InitializeComponent();
            force *= isMass ? 1 : 9.81;
            txtForce.Text = Convert.ToString(force);
            txtStroke.Text = Convert.ToString(stroke);
            cmb_force.SelectedIndex = isMass ? 0 : 1;
        }

        private void cmb_force_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_force.Text.Equals("Mass"))
                lbl_force.Text = "kg";
            else
                lbl_force.Text = "N";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var F = Double.Parse(txtForce.Text);

            var g = Double.Parse(txtStroke.Text);

            var V = int.Parse(txtVolyage.Text);

            var Tm = int.Parse(txtTemperature.Text);

            var Ta = int.Parse(txtAmbientTemp.Text);

            var q = Double.Parse(txt_Intermittentraiting.Text);

            var Alpha = int.Parse(txtHeightToDepthRatio.Text);

            var Inferior = int.Parse(txt_inferior.Text);

            var leakagefactor = Double.Parse(txt_leakage.Text);

            var K = Double.Parse(txt_thickness.Text);

            var L = Double.Parse(txt_plunger.Text);

            var M = Double.Parse(txt_brass.Text);

            var X = Double.Parse(txt_outside.Text);

            var O = Double.Parse(txt_allowance_irr.Text);

            var P = Double.Parse(txt_allowance_mica.Text);

            var Q = Double.Parse(txt_allowance_fibr.Text);



            var Bg = 1.1;  // todo calculate it
            var lambda = 0.00121;  // todo calculate it

            var ssf = Double.Parse(txtslotSpaceFactor.Text);
            
            // kg/cm
            var IndexNumber = Math.Sqrt(F) / g;


            // Area of plunger..........m^2
            var A = (F * 4 * Math.PI * Math.Pow(10, -7)) / (0.051 * Math.Pow(Bg, 2));


            // Radius of plunger.........mm
            var r1 = Math.Sqrt(A / Math.PI) * 1000;


            var mmf = 1; // todo calculate it!



            // برای دمای 75 درجه سانتیگراد .......واحد: اهم_سانتیمتر
            var Ro1 = 2.1 * Math.Pow(10, -6);
     
       

            // اگر دما از 75 درجه سانتی گراد تغییر کرد، بر اساس فرمول زیر مقدار جدید را بدست می آوریم
            // طبق فرمول زیر ارتفاع سیم پیچی را حساب می کنیم .......واحد: اهم_سانتیمتر
            var Ro2 = (Ro1 * (234.5 + (Tm + Ta))) / (234.5 + 75);



            // واحد: میلیمتر
            var hf = Math.Pow(((q * Ro2 * Math.Pow(mmf, 2) * Alpha) / (2 * lambda * ssf * Tm)), 3) * 10;



            // واحد: میلیمتر
            var dc = hf / Alpha;



            // واحد: میلیمتر
            var r2 = dc + r1;




            var r3 = Math.Sqrt(((Inferior / 100) * Math.Pow(r1, 2)) + Math.Pow(r2, 2));




            var t1 = ((Inferior / (100 * 2)) * r1);



            var t2 = ((Inferior / (100 * 2)) * (Math.Pow(r1, 2) / r2));



            // واحد: وبر
            var phi0 = leakagefactor * Math.PI * Math.Pow(r1, 2) * Math.Pow(10, -3) * Bg;




            var lgc = K + L;




            var mmfgc = 0.1 * mmf;




            var t4 = (800000 * phi0 * lgc) / (mmfgc);



            // واحد: متر مربع
            var Areaoffluxpatchthoughcylindricalgap = Math.PI * ((2 * r1) + lgc) * t4 * Math.Pow(10, -3);



            // واحد: وبر بر متر مربع
            var Bgc = phi0 / Areaoffluxpatchthoughcylindricalgap;



            // واحد: میلیمتر
            var d = (Math.Sqrt((4 * Ro2 * mmf * (r2 - r1) * Math.Pow(10, -1)))) * 10;




            var di = d + 0.2;




            var TotalAllowance = K + L + M + X + O;




            var Netwindingdepht = dc - TotalAllowance;




            var Numberoflayersdephtwise = dc / di;




            var Netwindingheight = (hf - P) - (2 * Q);




            var Numberoflayersheightwise = Netwindingheight / di;




            var N = Numberoflayersdephtwise * Numberoflayersheightwise;




            var az = (Math.PI / 4) * Math.Pow(d, 2);




            var lmt = Math.PI * (r1 + r2);




            var R = (Ro2 * lmt * Math.Pow(10, -1) * N) / (az * Math.Pow(10, -2));




            var I = V / R;




            var Totalmmf = N * I;





        }


    }
}
