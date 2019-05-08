using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UW : Form
    {
        public UW()
        {
            InitializeComponent();
        }
        double f=0; //Frequency
        double Distance = 0; //Distance(meter)
        double Deep = 0; //Deep(meter)
        double T = 0; //Temperature
        double L=0, Lhh = 0, Lht = 0, Llc = 0; //Loss
        double n = 1.5;
        double pH = 7; //pH
        double Sal; //Salinity
        
        private void UW_Load(object sender, EventArgs e)
        {
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            L = 0;
            try
            {
                f = float.Parse(txtFreq.Text);
                Distance = float.Parse(txtDistance.Text);
                Deep = float.Parse(txtDeep.Text);
                T = float.Parse(txtTemp.Text);
                pH = float.Parse(txtpH.Text);
                Sal = float.Parse(txtSalinity.Text);
            }
            catch{}
            Lhh = Cal_Lhh(Distance, n, 1);
            Lht = Cal_Lht(f, Distance, T, pH, Sal, Deep);
            Llc = Cal_Llc(f, cbxGround.Text, Distance);
            if (ckbHapthu.Checked) { L = L + Lht; }
            if (ckbHinhhoc.Checked) { L = L + Lhh; }
            if (ckbLangcan.Checked) { L = L + Llc; }
            if (ckbNoise.Checked) { L = L + Noise(f); }
            if (txtFreq.Text == "") L = 0;
            if (L < 0) { L = 0; }
            txtResult.Text = L.ToString();
        }
        private double Cal_Lht(double f, double Distance,double T, double pH, double S, double D)
        {
            double a=1;
            //double c = 1412 + 3.21 * T + 1.19 * S + 0.0167 * D;
            double c=1;

            if (T < 30 && T > -2 && S < 40 && S > 25 && D < 8000 && D > 0)
            {
                c = 1448.96 + 4.591 * T - 0.05304 * T * T + 2.374 * Math.Pow(10, -4) * Math.Pow(T, 3) + 1.34 * (S - 35) + 0.0163 * D + 1.675 * Math.Pow(10, -7) * Math.Pow(D, 2) - 0.01025 * T * (S - 35) - 7.139 * Math.Pow(10, -13) * T * Math.Pow(D, 3);
            }
            double f1 = 2.8 * Math.Sqrt(S / 35) * Math.Pow(10, 4 - 1245 / (T + 273));
            double f2 = (8.17 * Math.Pow(10, 8 - 1990 / (T + 273))) / (1 + 0.0018 * (S - 35));
            double A1 = (8.686 / c) * Math.Pow(10, 0.78 * pH - 5) * ((f1 * f * f) / (f1 * f1 + f * f));

            double A2 = 21.44 * S / c * (1 + 0.025 * T) * (1 - 1.37 * D * Math.Pow(10, -4) + 6.2 * Math.Pow(10, -9) * D * D) * ((f2 * f * f) / (f2 * f2 + f * f));
            
            if (T <= 20)
            {
                a = 4.937 * Math.Pow(10, -4) - 2.59 * Math.Pow(10, -5) * T + 9.11 * Math.Pow(10, -7) * T * T - 1.5 * Math.Pow(10, -8) * Math.Pow(T, 3);
            }
            if (T > 20)
            {
                a = 3.964 * Math.Pow(10, -4) - 1.146 * Math.Pow(10, -5) * T + 1.45 * Math.Pow(10, -7) * T * T - 6.5 * Math.Pow(10, -8) * Math.Pow(T, 3);
            }
            double A3 = a * (1 - 3.83 * Math.Pow(10, -5) * D + 4.9 * Math.Pow(10, -10) * D * D) * f * f;
            double A= A1 + A2 + A3;
            return 10*Math.Log10(A)*Distance; //dB

            //*Math.Pow(Math.E,(pH-8)/0.56)
        }
        private double Cal_Lhh(double Distance, double n, double r0)
        {
            return 10 * Math.Log10(Math.Pow((Distance / r0), n));
        }
        private double Cal_Llc(double f,string s, double Distance)
        {
            double K, n;
            switch (s)
            {
                case "Bùn rất mịn":
                    K = 0.17;
                    n = 0.96;
                    break;
                case "Cát mịn":
                    K = 0.45;
                    n = 1.02;
                    break;
                case "Cát trung bình":
                    K = 0.48;
                    n = 0.98;
                    break;
                case "Cát thô":
                    K = 0.53;
                    n = 0.96;
                    break;
                default: 
                    K=0.17;
                    n=0.96;
                    break;
            }
            return Distance*(1 / 8.686) * K * Math.Pow(f, n);
                
        }

        private void ckbLangcan_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbLangcan.Checked)
            {
                grbLC.Enabled = true;
            }
            if (!ckbLangcan.Checked)
            {
                grbLC.Enabled = false;
            }
        }

        private void ckbNoise_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbNoise.Checked)
            {
                grbNoise.Enabled = true;
            }
            if (!ckbNoise.Checked)
            {
                grbNoise.Enabled = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtDeep.Text = txtDistance.Text = txtFreq.Text = txtpH.Text = txtSalinity.Text = txtTemp.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(ret==DialogResult.OK)
            {
                Close();
            }
        }

        private double Noise(double f)
        {
            int s = 1; //(0-1)
            int w = Convert.ToInt32(txtWind.Text); //m/s
            double p_th = -1.5 + 2 * Math.Log10(f);
            double p_t= 1.7-3*Math.Log10(f);
            double p_w = 5 + 0.75 * Math.Sqrt(w) + 2 * Math.Log10(f) - 4 * Math.Log10(f+0.4);
            double p_s = 4 + 2 * (s - 0.5) + 2.6 * Math.Log10(f) - 6 * Math.Log10(f+0.03);
            double N_th= Math.Pow(10,p_th);
            double N_t = Math.Pow(10, p_t);
            double N_w = Math.Pow(10, p_w);
            double N_s = Math.Pow(10, p_s);
            return 10*Math.Log10(N_th + N_t + N_s + N_w);
        }
        

    }
}
