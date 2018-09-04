using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wochentag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tag = 0, tag_e, monat = 0, monat_e = 0, jahr = 0, jahr_hin = 0, jahr_hin_e, jahr_vor = 0, jahr_vor_e, schalt = 0, i, j;
            int[] monate = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string ergebnis = "Fehler";
            bool test = true, fehler = false;

            try
            {
                tag = Convert.ToInt32(tbx_tag.Text);
            }
            catch
            {
                MessageBox.Show("Diesen Tag gibt es nicht", "Fehler");

                fehler = true;
            }

            if (!fehler)
            {
                try
                {
                    monat = Convert.ToInt32(tbx_monat.Text);
                }
                catch
                {
                    MessageBox.Show("Diesen Monat gibt es nicht", "Fehler");

                    fehler = true;
                }

            }

            if (!fehler)
            {
                try
                {
                    jahr = Convert.ToInt32(tbx_jahr.Text);
                }
                catch
                {
                    MessageBox.Show("Dieses Jahr gibt es nicht", "Fehler");

                    fehler = true;
                }
            }

            if (!fehler)
            {

            if (jahr == 0)
            {
                string message = "Bist du Christ?";
                string caption = "Glaubensfrage";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (jahr == 0)
                    {
                        tbx_ausgabe.Text = "Problem";
                        tbx_ausgabe.TextAlign = HorizontalAlignment.Center;

                        MessageBox.Show("Es gibt im Christentum kein Jahr  0", "Problem");

                        fehler = true;
                    }
                    else
                    {
                    jahr = jahr - 1;
                    }
                }
            }
            }

            if (!fehler)
            {
            for (i = 0; test; i++)
            {
                j = jahr - (i * 100);

                if (j < 100)
                {
                    jahr_vor = i;
                    jahr_hin = j;

                    test = false;
                }
            }
     
                if (monat > 12 || monat < 1)
                {
                    fehler = true;

                    MessageBox.Show("Diesen Monat gibt es nicht", "Fehler");
                }
                else
                {
                    if (tag > (monate[(monat - 1)]) || tag < 1)
                    {
                        if ((jahr % 4) == 0 && monat == 2 && tag == 29)
                        {

                        }
                        else
                        {
                            fehler = true;

                            MessageBox.Show("Diesen Tag gibt es nicht", "Fehler");
                        }
                    }
                }
            }

            if (!fehler)
            {
                tag_e = tag % 7;

                for (i = 1; i < monat; i++)
                {
                    if (i == 1)
                    {
                        monat_e = 3;
                    }
                    else
                    {
                        monat_e = monat_e + (monate[(i - 1)] % 7);
                    }

                    if (monat_e > 6)
                    {
                        monat_e = monat_e % 7;
                    }
                }

                jahr_vor_e = (3 - (jahr_vor % 4)) * 2;

                jahr_hin_e = (jahr_hin + (jahr_hin / 4)) % 7;

                if ((jahr % 4) == 0 && monat <= 2)
                {
                    schalt = 6;
                }

                i = tag_e + monat_e + jahr_vor_e + jahr_hin_e + schalt;

                if (i > 6)
                {
                    i = i % 7;
                }

                if (i == 0)
                {
                    ergebnis = "Sonntag";
                }

                if (i == 1)
                {
                    ergebnis = "Montag";
                }

                if (i == 2)
                {
                    ergebnis = "Dienstag";
                }

                if (i == 3)
                {
                    ergebnis = "Mittwoch";
                }

                if (i == 4)
                {
                    ergebnis = "Donnerstag";
                }

                if (i == 5)
                {
                    ergebnis = "Freitag";
                }

                if (i == 6)
                {
                    ergebnis = "Samstag";
                }


                tbx_ausgabe.Text = ergebnis;
            }

            tbx_ausgabe.TextAlign = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
