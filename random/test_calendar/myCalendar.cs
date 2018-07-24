using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace test_calendar
{
    class myCalendar
    {
        #region variables

        public enum firstDay { SUN, MON, TUE, WED, THU, FRI, SAT }
        public firstDay fday { get; set; }
        public Panel pnel { get; set; }
        Label[] dayName = new Label[7];
        Button[] arrDay = new Button[30];
        dayForm _dayForm;
        private int _cuSeason = 0, _cuDay = 0;
        private string _Season;

        #endregion variables

        #region method

        public myCalendar()
        {
            this.fday = (myCalendar.firstDay)_cuDay;
        }

        public myCalendar(firstDay fistDay, Panel Panel)
        {
            createCalendar((int)fistDay, Panel);
        }

        public void showCalendar()
        {
            if (pnel != null)
            {
                //createCalendar((int)fday, pnel);
                createSeason(pnel);
            }
        }

        private void createCalendar(int startDay, Panel p)
        {
            int xPos = 0, yPos = 0;
            foreach (Label i in dayName) p.Controls.Remove(i);
            foreach (Button i in arrDay) p.Controls.Remove(i);
            for (int i = 0; i < 7; i++)
            {
                Label dName = new Label();
                dName.Size = new Size(35, 30);
                dName.TextAlign = ContentAlignment.MiddleCenter;
                //dName.BorderStyle = BorderStyle.Fixed3D;
                //dName.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8, FontStyle.Bold);
                if (i == 0) dName.Name = "SUN";
                else if (i == 1) dName.Name = "MON";
                else if (i == 2) dName.Name = "TUE";
                else if (i == 3) dName.Name = "WED";
                else if (i == 4) dName.Name = "THU";
                else if (i == 5) dName.Name = "FRI";
                else if (i == 6) dName.Name = "SAT";
                dName.Text = dName.Name;
                dName.Location = new Point(xPos, yPos);
                dayName[i] = dName;
                xPos += 35;
            }
            xPos = startDay * 35; yPos = 30;
            for (int i = 1; i <= 30; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(35, 30);
                btn.Name = "day_" + i;
                btn.Text = i.ToString();
                btn.Location = new Point(xPos, yPos);
                btn.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8, FontStyle.Bold);
                btn.Click += (obj, ev) =>
                {
                    showForm(ref _dayForm, btn.Name);
                    var mF = Application.OpenForms[0];
                    _dayForm.Text = string.Concat(_Season, " ", btn.Text);
                    _dayForm.Location = new Point((mF.Location.X + mF.Width), mF.Location.Y);
                    _dayForm.LocationChanged += (obj2, ev2) =>
                    {
                        mF.Location = new Point(_dayForm.Location.X - mF.Width, _dayForm.Location.Y);
                    }; 
                };
                if (isDAY(i, 0, startDay))
                {
                    btn.ForeColor = Color.Red;
                    btn.Tag = "SUN";
                }
                if (isDAY(i, 2, startDay))
                {
                    btn.ForeColor = Color.Green;
                    btn.Tag = "TUE";
                }
                if ((i + startDay) % 7 == 0)
                {
                    yPos += 30; xPos = 0;
                }
                else xPos += 35;
                arrDay[i - 1] = btn;
            }
            foreach (Label i in dayName) p.Controls.Add(i);
            foreach (Button i in arrDay) p.Controls.Add(i);
        }

        private void createSeason(Panel p)
        {
            p.Size = new Size((35 * 7) + 2, (30 * 7) + 2);
            //p.BorderStyle = BorderStyle.FixedSingle;
            ComboBox list_season = new ComboBox();
            ComboBox list_hari = new ComboBox();
            string[] season = { "Spring", "Summer", "Autumn", "Winter" };
            string[] hari = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            p.Controls.Remove(list_season);
            p.Controls.Remove(list_hari);
            list_season.Location = new Point(36, (30 * 6) + 4);
            list_season.Size = new Size(103, 20);
            list_season.Items.AddRange(season);
            list_season.DropDownStyle = ComboBoxStyle.DropDownList;
            list_season.SelectedIndexChanged += (obj, ev) =>
            {
                _cuSeason = list_season.SelectedIndex;
                _Season = list_season.SelectedItem.ToString();
                if (Application.OpenForms.Count > 1)
                {
                    Application.OpenForms[1].Dispose();
                }
                createCalendar(_cuDay, pnel);
            };
            list_season.SelectedIndex = 0;//Spring
            list_hari.Location = new Point(141, (30 * 6) + 4);
            list_hari.Size = new Size(103, 20);
            list_hari.Items.AddRange(hari);
            list_hari.DropDownStyle = ComboBoxStyle.DropDownList;
            list_hari.SelectedIndexChanged += (obj, ev) =>
            {
                _cuDay = list_hari.SelectedIndex;
                createCalendar(_cuDay, pnel);
            };
            list_hari.SelectedIndex = 0;//Sunday
            p.Controls.Add(list_season);
            p.Controls.Add(list_hari);
        }

        private bool isDAY(int check, int hari, int startDay)
        {
            //hari 0=SUN, 1=MON, 2=TUE, 3=WED, 4=THU, 5=FRI, 6=SAT
            bool hsl = false;
            List<int> tmp = new List<int>();
            int x = 0;
            if (startDay > hari) x = (7 - startDay) + hari;
            else if (startDay - hari == 0) x = 0;
            else if (hari > startDay) x = hari - startDay;
            for (int i = 0; i < 5; i++)
            {
                //Console.Write((x + (7 * i) + 1) + " ");
                tmp.Add((x + (7 * i) + 1));
            }
            if (tmp.Contains(check)) hsl = true;
            return hsl;
        }

        private void showForm<T>(ref T newForm, string today)
        {
            var targetForm = (newForm as Form);
            if (newForm == null || !targetForm.IsHandleCreated)
            {
                Type t = typeof(T);
                Assembly a = Assembly.GetAssembly(t);
                newForm = (T)Convert.ChangeType(a.CreateInstance(t.FullName), t);
                Form form = newForm as Form;
                form.Tag = today;
                form.Show();
                form.Focus();
            }
            else
            {
                if ((string)targetForm.Tag == today)
                {
                    targetForm.Close();
                    targetForm.Dispose();
                }
                else
                {
                    targetForm.Close();
                    targetForm.Dispose();
                    showForm(ref newForm, today);
                }
            }
        }

        #endregion method
    }
}
