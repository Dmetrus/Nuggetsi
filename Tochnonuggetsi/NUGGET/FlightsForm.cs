using System;
using System.Drawing;
using System.Windows.Forms;
using NUGGET.models;

namespace NUGGET
{
    public partial class FlightsForm : Form
    {
        private readonly Flights flights;
        public string text = "Боинг";

        public FlightsForm()
        {
            InitializeComponent();
            FillDirection();
            this.Text = "Добавление рейса";
            flights = new Flights
            {
                numflight = 1,
                type = Types.Боинг,
                eta = DateTime.Now.AddDays(1),
                countPas = (int)numericCountPas.Value,
                pricePas = (double)numericPricePas.Value,
                countCrew = (int)numericCountCrew.Value,
                priceCrew = (double)numericPriceCrew.Value,
                procDop = (double)numericProcDop.Value,
                sum = 7200
            };
            comboType.SelectedItem = flights.type;
        }

        public FlightsForm(Flights source):this()
        {
            this.Text = "Редактирование рейса";
            numericFlight.Value = source.numflight;
            comboType.SelectedItem = source.type;
            dateTimeETA.Value = source.eta;
            numericCountPas.Value = source.countPas;
            numericCountCrew.Value = source.countCrew;
            numericPricePas.Value = (decimal)source.pricePas;
            numericPriceCrew.Value = (decimal)source.priceCrew;
            numericProcDop.Value = (decimal)source.procDop;
            textSum.Text = source.sum.ToString();
        }
        public Flights Flights => flights;

        private void FillDirection()
        {
            foreach(Types type in Enum.GetValues(typeof(Types)))
            {
                comboType.Items.Add(type);
            }
        }

        private void comboType_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if(parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if(e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Types type)
                    {
                        text = type.ToString();
                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                    e.Graphics.DrawString(
                            parent.Items[e.Index].ToString(),
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                }
                
            }
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboType.SelectedIndex >= 0)
            {
                flights.type = (Types)comboType.SelectedItem;
            }
        }

        private void numericFlight_ValueChanged(object sender, EventArgs e)
        {
            flights.numflight = (int)numericFlight.Value;
        }

        private void dateTimeETA_ValueChanged(object sender, EventArgs e)
        {
            flights.eta = dateTimeETA.Value;
        }

        private void numericCountPas_ValueChanged(object sender, EventArgs e)
        {
            flights.countPas = (int)numericCountPas.Value;
            textSum.Text = ((flights.countPas * flights.pricePas + flights.countCrew * flights.priceCrew) *
                (1 + flights.procDop * 0.01)).ToString();
        }

        private void numericPricePas_ValueChanged(object sender, EventArgs e)
        {
            flights.pricePas = (double)numericPricePas.Value;
            textSum.Text = ((flights.countPas * flights.pricePas + flights.countCrew * flights.priceCrew) *
                (1 + flights.procDop * 0.01)).ToString();
        }

        private void numericCountCrew_ValueChanged(object sender, EventArgs e)
        {
            flights.countCrew = (int)numericCountCrew.Value;
            textSum.Text = ((flights.countPas * flights.pricePas + flights.countCrew * flights.priceCrew) *
                (1 + flights.procDop * 0.01)).ToString();
        }

        private void numericPriceCrew_ValueChanged(object sender, EventArgs e)
        {
            flights.priceCrew = (double)numericPriceCrew.Value;
            textSum.Text = ((flights.countPas * flights.pricePas + flights.countCrew * flights.priceCrew) *
                (1 + flights.procDop * 0.01)).ToString();
        }
        private void numericProcDop_ValueChanged(object sender, EventArgs e)
        {
            flights.procDop = (int)numericProcDop.Value;
            textSum.Text = ((flights.countPas * flights.pricePas + flights.countCrew * flights.priceCrew) *
                (1 + flights.procDop * 0.01)).ToString();
        }

        private void textSum_TextChanged(object sender, EventArgs e)
        {
            flights.sum = double.Parse(textSum.Text);
        }
    }
}
